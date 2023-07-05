﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpecDataBase.DAL;

#nullable disable

namespace OpecDataBase.DAL.Migrations
{
    [DbContext(typeof(OpecAcademyContext))]
    [Migration("20230703172315_nullableobjInClass")]
    partial class nullableobjInClass
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OPEC_Academy_API.Models.Branch", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Supervisor_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Supervisor_ID")
                        .IsUnique();

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<int>("Created_BY")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Created_BY");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<int>("Created_BY")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Payment")
                        .HasColumnType("datetime2");

                    b.Property<int>("Enroll_ID")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Paid")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Created_BY");

                    b.HasIndex("Enroll_ID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Student", b =>
                {
                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Apllying_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ar_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birth_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<int>("Created_BY")
                        .HasColumnType("int");

                    b.Property<string>("En_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Identity_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Military")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Personal_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quaification_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification_Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recommend")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Religion_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Studying_Year")
                        .HasColumnType("datetime2");

                    b.HasKey("SSN");

                    b.HasIndex("Created_BY");

                    b.HasIndex("Religion_ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<int>("Created_BY")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("Created_BY");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("OpecDataBase.DAL.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Lang_Id")
                        .HasColumnType("int");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BranchId");

                    b.HasIndex("Lang_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("OpecDataBase.DAL.Models.Enrollments", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Branch_Id")
                        .HasColumnType("int");

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Student_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("Branch_Id");

                    b.HasIndex("Course_Id");

                    b.HasIndex("Student_Id");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("OpecDataBase.DAL.Models.Language", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("OpecDataBase.DAL.Models.Religion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Religions");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Branch", b =>
                {
                    b.HasOne("OpecDataBase.DAL.Models.Employee", "Supervisor")
                        .WithOne("Branch_Mng")
                        .HasForeignKey("OPEC_Academy_API.Models.Branch", "Supervisor_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Course", b =>
                {
                    b.HasOne("OpecDataBase.DAL.Models.Employee", "Employee")
                        .WithMany("Courses")
                        .HasForeignKey("Created_BY")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Payment", b =>
                {
                    b.HasOne("OpecDataBase.DAL.Models.Employee", "Employee")
                        .WithMany("Payments")
                        .HasForeignKey("Created_BY")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpecDataBase.DAL.Models.Enrollments", "Student_Course_Branch")
                        .WithMany("payments")
                        .HasForeignKey("Enroll_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Student_Course_Branch");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Student", b =>
                {
                    b.HasOne("OpecDataBase.DAL.Models.Employee", "Employee")
                        .WithMany("Students")
                        .HasForeignKey("Created_BY")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpecDataBase.DAL.Models.Religion", "Religion")
                        .WithMany("Students")
                        .HasForeignKey("Religion_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Religion");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Subject", b =>
                {
                    b.HasOne("OPEC_Academy_API.Models.Course", null)
                        .WithMany("Subjects")
                        .HasForeignKey("CourseID");

                    b.HasOne("OpecDataBase.DAL.Models.Employee", "Employee")
                        .WithMany("Subjects")
                        .HasForeignKey("Created_BY")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("OpecDataBase.DAL.Models.Employee", b =>
                {
                    b.HasOne("OPEC_Academy_API.Models.Branch", "Branch")
                        .WithMany("Employees")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpecDataBase.DAL.Models.Language", "Language")
                        .WithMany("Employees")
                        .HasForeignKey("Lang_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("OpecDataBase.DAL.Models.Enrollments", b =>
                {
                    b.HasOne("OPEC_Academy_API.Models.Branch", "Branch")
                        .WithMany("Enrollments")
                        .HasForeignKey("Branch_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OPEC_Academy_API.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OPEC_Academy_API.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("Student_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Branch", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Course", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("OPEC_Academy_API.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("OpecDataBase.DAL.Models.Employee", b =>
                {
                    b.Navigation("Branch_Mng")
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Payments");

                    b.Navigation("Students");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("OpecDataBase.DAL.Models.Enrollments", b =>
                {
                    b.Navigation("payments");
                });

            modelBuilder.Entity("OpecDataBase.DAL.Models.Language", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("OpecDataBase.DAL.Models.Religion", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
