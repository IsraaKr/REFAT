﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using REFAT.Data.EF;

namespace REFAT.Data.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20240721043714_Add_all")]
    partial class Add_all
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("REFAT.Core.Employes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CurrentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentDegree")
                        .HasColumnType("int");

                    b.Property<float>("CurrentSalary")
                        .HasColumnType("real");

                    b.Property<int>("CurrentStage")
                        .HasColumnType("int");

                    b.Property<string>("EmpSate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTittle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastPromotionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NextDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NextDegree")
                        .HasColumnType("int");

                    b.Property<float>("NextSalary")
                        .HasColumnType("real");

                    b.Property<int>("NextStage")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employes");
                });

            modelBuilder.Entity("REFAT.Core.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.Property<bool>("Value")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("REFAT.Core.SalaryRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("BonusYearRate")
                        .HasColumnType("real");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("PromotionYear")
                        .HasColumnType("int");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SalaryRate");
                });

            modelBuilder.Entity("REFAT.Core.SystemRecords", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desiccation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachinId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SystemRecords");
                });

            modelBuilder.Entity("REFAT.Core.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EditedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSecondaryUser")
                        .HasColumnType("bit");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("REFAT.Core.Roles", b =>
                {
                    b.HasOne("REFAT.Core.Users", "Users")
                        .WithMany("Roles")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
