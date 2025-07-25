﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _9_EFOnlineCourseDB.Context;

#nullable disable

namespace _9_EFOnlineCourseDB.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Course", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<Guid>("InstructorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Exam", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("ExamDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.ExamResult", b =>
                {
                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("ExamNote")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("StudentID", "ExamID");

                    b.HasIndex("ExamID");

                    b.ToTable("ExamResults");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Instructor", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Professions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCKimlikNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Lesson", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CourseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("Duration")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Registration", b =>
                {
                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentID", "CourseID");

                    b.HasIndex("CourseID");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Student", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCKimlikNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Course", b =>
                {
                    b.HasOne("_9_EFOnlineCourseDB.Entities.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.ExamResult", b =>
                {
                    b.HasOne("_9_EFOnlineCourseDB.Entities.Exam", "Exam")
                        .WithMany("ExamResults")
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_9_EFOnlineCourseDB.Entities.Student", "Student")
                        .WithMany("ExamResults")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Lesson", b =>
                {
                    b.HasOne("_9_EFOnlineCourseDB.Entities.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Registration", b =>
                {
                    b.HasOne("_9_EFOnlineCourseDB.Entities.Course", "Course")
                        .WithMany("Registrations")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_9_EFOnlineCourseDB.Entities.Student", "Student")
                        .WithMany("Registrations")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Course", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Exam", b =>
                {
                    b.Navigation("ExamResults");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Instructor", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("_9_EFOnlineCourseDB.Entities.Student", b =>
                {
                    b.Navigation("ExamResults");

                    b.Navigation("Registrations");
                });
#pragma warning restore 612, 618
        }
    }
}
