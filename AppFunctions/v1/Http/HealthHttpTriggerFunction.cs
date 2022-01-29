using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace AndreFischbacherApp.Functions.v1.Http
{
	public class HealthHttpTriggerFunction
	{
		[FunctionName(nameof(HealthHttpTriggerFunction))]
		public async Task<IActionResult> Run(
			[HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "ok")] HttpRequest req,
			ILogger log)
		{ 
			return new OkObjectResult("Ok");
		}
	}
}
