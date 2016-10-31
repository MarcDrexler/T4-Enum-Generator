using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EfCodeFirstSql.Models;

namespace EfCodeFirstSql.Migrations
{
    [DbContext(typeof(SampleContext))]
    partial class SampleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("EfCodeFirstSql.Models.Parent", b =>
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

            modelBuilder.Entity("EfCodeFirstSql.Models.Child", b =>
                {
                    b.HasBaseType("EfCodeFirstSql.Models.Parent");


                    b.ToTable("Child");

                    b.HasDiscriminator().HasValue("Child");
                });
        }
    }
}
