﻿// <auto-generated />
using System;
using AndreFischbacherApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AndreFischbacherApp.DataContext.Migrations
{
    [DbContext(typeof(AndreFischbacherAppContext))]
    [Migration("20190826014020_addUrlAndTitle")]
    partial class addUrlAndTitle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AndreFischbacherApp.DataContext.Entities.CareerContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("CompanyName")
                        .HasColumnName("CompanyName");

                    b.Property<string>("Description")
                        .HasColumnName("Description");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnName("EndDate");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnName("LastModified");

                    b.Property<string>("PositionTitle")
                        .HasColumnName("PositionTitle");

                    b.Property<DateTime>("StartDate")
                        .HasColumnName("StartDate");

                    b.HasKey("Id");

                    b.ToTable("CareerContents");
                });

            modelBuilder.Entity("AndreFischbacherApp.DataContext.Entities.CareerInformationContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<Guid>("CareerContentId");

                    b.Property<string>("CareerInformation")
                        .HasColumnName("CareerInformation");

                    b.HasKey("Id");

                    b.HasIndex("CareerContentId");

                    b.ToTable("CareerInformationContents");
                });

            modelBuilder.Entity("AndreFischbacherApp.DataContext.Entities.InterestContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Contents")
                        .HasColumnName("Contents");

                    b.Property<string>("ImageUrl")
                        .HasColumnName("ImageUrl");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnName("LastModified");

                    b.Property<string>("Title")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("InterestContents");
                });

            modelBuilder.Entity("AndreFischbacherApp.Repositories.Entities.AboutContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Content")
                        .HasColumnName("Content");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnName("LastModified");

                    b.HasKey("Id");

                    b.ToTable("AboutContents");
                });

            modelBuilder.Entity("AndreFischbacherApp.DataContext.Entities.CareerInformationContent", b =>
                {
                    b.HasOne("AndreFischbacherApp.DataContext.Entities.CareerContent")
                        .WithMany("CareerInformationContents")
                        .HasForeignKey("CareerContentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
