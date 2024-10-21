﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecodeProject.Models;

#nullable disable

namespace RecodeProject.Migrations
{
    [DbContext(typeof(CursoDbContext))]
    [Migration("20241020025320_SeedCursos")]
    partial class SeedCursos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RecodeProject.Models.Curso", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Workload")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Curso");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Asp Net MVC",
                            Workload = 40
                        },
                        new
                        {
                            ID = 2,
                            Description = "Banco de Dados",
                            Workload = 30
                        },
                        new
                        {
                            ID = 3,
                            Description = "React",
                            Workload = 60
                        },
                        new
                        {
                            ID = 4,
                            Description = "HTML e CSS",
                            Workload = 20
                        },
                        new
                        {
                            ID = 5,
                            Description = "C#",
                            Workload = 50
                        },
                        new
                        {
                            ID = 6,
                            Description = "Python",
                            Workload = 45
                        });
                });
#pragma warning restore 612, 618
        }
    }
}