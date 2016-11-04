using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EfCodeFirstSqlVs.Models;

namespace EfCodeFirstSqlVs.Migrations
{
    [DbContext(typeof(SampleContext))]
    [Migration("20161104055124_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfCodeFirstSqlVs.Models.LanguageString", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Language");

                    b.Property<string>("Text");

                    b.Property<int?>("UniqueClassId");

                    b.HasKey("Id");

                    b.HasIndex("UniqueClassId");

                    b.ToTable("LanguageStrings");
                });

            modelBuilder.Entity("EfCodeFirstSqlVs.Models.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Parents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Parent");
                });

            modelBuilder.Entity("EfCodeFirstSqlVs.Models.UniqueClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("InternalId");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("UniqueClasses");
                });

            modelBuilder.Entity("EfCodeFirstSqlVs.Models.Child", b =>
                {
                    b.HasBaseType("EfCodeFirstSqlVs.Models.Parent");


                    b.ToTable("Child");

                    b.HasDiscriminator().HasValue("Child");
                });

            modelBuilder.Entity("EfCodeFirstSqlVs.Models.LanguageString", b =>
                {
                    b.HasOne("EfCodeFirstSqlVs.Models.UniqueClass", "UniqueClass")
                        .WithMany("Name")
                        .HasForeignKey("UniqueClassId");
                });
        }
    }
}
