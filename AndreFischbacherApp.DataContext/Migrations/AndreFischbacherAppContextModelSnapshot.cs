﻿// <auto-generated />
using System;
using AndreFischbacherApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AndreFischbacherApp.DataContext.Migrations
{
    [DbContext(typeof(AndreFischbacherAppContext))]
    partial class AndreFischbacherAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AndreFischbacherApp.DataContext.Entities.CareerContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyLogoUrl")
                        .HasColumnName("CompanyLogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnName("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnName("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnName("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("PositionTitle")
                        .HasColumnName("PositionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnName("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CareerContents");
                });

            modelBuilder.Entity("AndreFischbacherApp.DataContext.Entities.CareerInformationContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CareerContentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CareerInformation")
                        .HasColumnName("CareerInformation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CareerContentId");

                    b.ToTable("CareerInformationContents");
                });

            modelBuilder.Entity("AndreFischbacherApp.DataContext.Entities.InterestContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Contents")
                        .HasColumnName("Contents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnName("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnName("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InterestContents");
                });

            modelBuilder.Entity("AndreFischbacherApp.Repositories.Entities.AboutContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnName("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconName")
                        .HasColumnName("IconName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSubcard")
                        .HasColumnName("IsSubcard")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnName("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutContents");
                });

            modelBuilder.Entity("AndreFischbacherApp.DataContext.Entities.CareerInformationContent", b =>
                {
                    b.HasOne("AndreFischbacherApp.DataContext.Entities.CareerContent", null)
                        .WithMany("CareerInformationContents")
                        .HasForeignKey("CareerContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
