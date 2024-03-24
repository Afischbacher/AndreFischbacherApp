using AndreFischbacherApp.DataContext.Configuration;
using AndreFischbacherApp.Repositories;
using AndreFischbacherApp.Services.Features.Functions.Services;
using AndreFischbacherApp.Services.Mediator.Base;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>(optional: true, reloadOnChange: true);

var connectionString = builder.Configuration.GetConnectionString("DatabaseConnectionString");
ArgumentNullException.ThrowIfNull(connectionString, "Database connection string is missing");


// Add DbContext and SQL connection
builder.Services
    .AddDbContextPool<IAndreFischbacherAppContext, AndreFischbacherAppContext>(options => options.UseSqlServer(connectionString));

// Register Mediator
builder.Services.AddMediatR((config) => 
{
    config.RegisterServicesFromAssembly(typeof(IMediatorServicesBase).Assembly);
});

// Http Client
builder.Services.AddHttpClient();

// App Settings
builder.Services.AddScoped<IAppConfiguration, AppConfiguration>();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache(config => 
{
});

// Repositories
builder.Services.AddScoped<IInterestsContentRepository, InterestsContentRepository>();
builder.Services.AddScoped<IAboutMeContentRepository, AboutMeContentRepository>();
builder.Services.AddScoped<ICareerContentRepository, CareerContentRepository>();

// Services
builder.Services.AddScoped<IFunctionWarmingService, FunctionWarmingService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
