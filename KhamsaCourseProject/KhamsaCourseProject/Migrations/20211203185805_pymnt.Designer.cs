﻿// <auto-generated />
using System;
using KhamsaCourseProject.Areas.Admin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KhamsaCourseProject.Migrations
{
    [DbContext(typeof(AdminContext))]
    [Migration("20211203185805_pymnt")]
    partial class pymnt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Check", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("PaymentId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Checks");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.ContractType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("ContractTypes");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Debt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Cost")
                        .HasColumnType("double");

                    b.Property<DateTime>("CostDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.ToTable("Debts");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Avans")
                        .HasColumnType("double");

                    b.Property<double>("Bonus")
                        .HasColumnType("double");

                    b.Property<int>("EmployeeLessonTypeId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Fullname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Payment")
                        .HasColumnType("double");

                    b.Property<int>("PaymentPerHour")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeTypeId");

                    b.HasIndex("SectorId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.EmployeeLessonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("EmployeeLessonTypes");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.EmployeeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("EmployeeTypes");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Benefit")
                        .HasColumnType("double");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.Property<int>("StudentCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.ExtraDebt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Cost")
                        .HasColumnType("double");

                    b.Property<DateTime>("CostDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.ToTable("ExtraDebts");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.ExtraPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Benefit")
                        .HasColumnType("double");

                    b.Property<DateTime>("BenefitDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.ToTable("ExtraPayments");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Cost")
                        .HasColumnType("double");

                    b.Property<DateTime>("CostDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.PaymentCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("PaymentCategories");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Benefit")
                        .HasColumnType("double");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Fax")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<string>("Fullname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HomeNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.Property<int>("StudentClassId")
                        .HasColumnType("int");

                    b.Property<int>("StudentGroupId")
                        .HasColumnType("int");

                    b.Property<int>("StudentLessonSectorId")
                        .HasColumnType("int");

                    b.Property<int>("StudentTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.HasIndex("StudentClassId");

                    b.HasIndex("StudentGroupId");

                    b.HasIndex("StudentLessonSectorId");

                    b.HasIndex("StudentTypeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.StudentClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("StudentClasses");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.StudentContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ContractTypeId")
                        .HasColumnType("int");

                    b.Property<double>("Debt")
                        .HasColumnType("double");

                    b.Property<double>("Discount")
                        .HasColumnType("double");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ContractTypeId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.StudentGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("StudentGroups");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.StudentLessonSector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("StudentLessonSectors");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.StudentPayment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PaymentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PaymentTypeId");

                    b.HasIndex("SectorId");

                    b.HasIndex("StudentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.StudentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("StudentTypes");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Permission")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Surname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Token")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Check", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.PaymentCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Debt", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Employee", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.EmployeeType", "EmployeeType")
                        .WithMany()
                        .HasForeignKey("EmployeeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Exam", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Sector", "Sector")
                        .WithMany("Exams")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.ExtraDebt", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.ExtraPayment", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Office", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Publication", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Sector", "Sector")
                        .WithMany("Publications")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Role", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.Student", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Sector", "Sector")
                        .WithMany("Students")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.StudentClass", "StudentClass")
                        .WithMany("Students")
                        .HasForeignKey("StudentClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.StudentGroup", "StudentGroup")
                        .WithMany("Students")
                        .HasForeignKey("StudentGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.StudentLessonSector", "StudentLessonSector")
                        .WithMany("Students")
                        .HasForeignKey("StudentLessonSectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.StudentType", "StudentType")
                        .WithMany("Students")
                        .HasForeignKey("StudentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.StudentContract", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.ContractType", "ContractType")
                        .WithMany("Contracts")
                        .HasForeignKey("ContractTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Student", "Student")
                        .WithOne("Contract")
                        .HasForeignKey("KhamsaCourseProject.Areas.Admin.Models.StudentContract", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhamsaCourseProject.Areas.Admin.Models.StudentPayment", b =>
                {
                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.PaymentCategory", "Category")
                        .WithMany("Payments")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Employee", null)
                        .WithMany("StudentPayments")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.PaymentType", "PaymentType")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KhamsaCourseProject.Areas.Admin.Models.Student", null)
                        .WithMany("StudentPayments")
                        .HasForeignKey("StudentId");
                });
#pragma warning restore 612, 618
        }
    }
}
