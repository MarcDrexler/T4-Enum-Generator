using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EfCodeFirstSqlliteVsCode.Models;

namespace EfCodeFirstSqlliteVsCode.Migrations
{
    [DbContext(typeof(SampleContext))]
    [Migration("20161031060931_DemoData")]
    partial class DemoData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("EfCodeFirstSqlliteVsCode.Models.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Parents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Parent");
                });

            modelBuilder.Entity("EfCodeFirstSqlliteVsCode.Models.Child", b =>
                {
                    b.HasBaseType("EfCodeFirstSqlliteVsCode.Models.Parent");


                    b.ToTable("Child");

                    b.HasDiscriminator().HasValue("Child");
                });
        }
    }
}
