﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignedProfessorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModificatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssignedProfessorId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssignedProfessorId = 5,
                            Description = "Question Description 1 for testing",
                            EndDate = new DateTime(2024, 5, 28, 19, 1, 55, 155, DateTimeKind.Local).AddTicks(6738),
                            StudentId = 1,
                            SubjectId = 1,
                            Title = "Question Title 1 for testing"
                        },
                        new
                        {
                            Id = 2,
                            AssignedProfessorId = 4,
                            Description = "Question Description 2 for testing",
                            EndDate = new DateTime(2024, 5, 28, 19, 1, 55, 155, DateTimeKind.Local).AddTicks(6740),
                            StudentId = 1,
                            SubjectId = 1,
                            Title = "Question Title 2 for testing"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Response", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserCreationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserCreationId");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("Domain.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Quarter")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Programación 3",
                            Quarter = "Tercer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Programación 4",
                            Quarter = "Tercer"
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("UserType").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ProfessorSubject", b =>
                {
                    b.Property<int>("ProfessorsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProfessorsId", "SubjectsId");

                    b.HasIndex("SubjectsId");

                    b.ToTable("ProfessorSubject");
                });

            modelBuilder.Entity("StudentSubject", b =>
                {
                    b.Property<int>("StudentsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectsAttendedId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentsId", "SubjectsAttendedId");

                    b.HasIndex("SubjectsAttendedId");

                    b.ToTable("StudentSubject");
                });

            modelBuilder.Entity("Domain.Entities.Professor", b =>
                {
                    b.HasBaseType("Domain.Entities.User");

                    b.HasDiscriminator().HasValue("Professor");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Email = "nbologna31@gmail.com",
                            LastName = "Bologna",
                            Name = "Nicolas",
                            Password = "123456",
                            UserType = "Profesor",
                            Username = "nbologna_profesor"
                        },
                        new
                        {
                            Id = 5,
                            Email = "ppaez@gmail.com",
                            LastName = "Paez",
                            Name = "Pablo",
                            Password = "123456",
                            UserType = "Profesor",
                            Username = "ppaez"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.HasBaseType("Domain.Entities.User");

                    b.HasDiscriminator().HasValue("Student");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "nbologna31@gmail.com",
                            LastName = "Bologna",
                            Name = "Nicolas",
                            Password = "123456",
                            UserType = "Estudiante",
                            Username = "nbologna_alumno"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Jperez@gmail.com",
                            LastName = "Perez",
                            Name = "Juan",
                            Password = "123456",
                            UserType = "Estudiante",
                            Username = "jperez"
                        },
                        new
                        {
                            Id = 3,
                            Email = "pgarcia@gmail.com",
                            LastName = "Garcia",
                            Name = "Pedro",
                            Password = "123456",
                            UserType = "Estudiante",
                            Username = "pgarcia"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.HasOne("Domain.Entities.Professor", "AssignedProfessor")
                        .WithMany("Questions")
                        .HasForeignKey("AssignedProfessorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Student", "Student")
                        .WithMany("Questions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Subject", "Subject")
                        .WithMany("Questions")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AssignedProfessor");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Domain.Entities.Response", b =>
                {
                    b.HasOne("Domain.Entities.Question", "Question")
                        .WithMany("Responses")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "UserCreation")
                        .WithMany()
                        .HasForeignKey("UserCreationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("UserCreation");
                });

            modelBuilder.Entity("ProfessorSubject", b =>
                {
                    b.HasOne("Domain.Entities.Professor", null)
                        .WithMany()
                        .HasForeignKey("ProfessorsId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentSubject", b =>
                {
                    b.HasOne("Domain.Entities.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsAttendedId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.Navigation("Responses");
                });

            modelBuilder.Entity("Domain.Entities.Subject", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Domain.Entities.Professor", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
