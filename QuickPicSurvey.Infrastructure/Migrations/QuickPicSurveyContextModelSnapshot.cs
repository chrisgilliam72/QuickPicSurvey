﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickPicSurvey.Infrastructure;

#nullable disable

namespace QuickPicSurvey.Infrastructure.Migrations
{
    [DbContext(typeof(QuickPicSurveyContext))]
    partial class QuickPicSurveyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuickPicSurvey.Domain.Models.Objective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Expectation")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Objectives");
                });

            modelBuilder.Entity("QuickPicSurvey.Domain.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Text = "Internal Meetings"
                        },
                        new
                        {
                            Id = 2,
                            Text = "Client Meetings"
                        },
                        new
                        {
                            Id = 3,
                            Text = "Emails & Phone / Skype calls"
                        },
                        new
                        {
                            Id = 4,
                            Text = "Research"
                        },
                        new
                        {
                            Id = 5,
                            Text = "DB Design"
                        },
                        new
                        {
                            Id = 6,
                            Text = "Architecture Design and Planning"
                        },
                        new
                        {
                            Id = 7,
                            Text = "Back-end Development"
                        },
                        new
                        {
                            Id = 8,
                            Text = "Front-end Development"
                        },
                        new
                        {
                            Id = 9,
                            Text = "Integration"
                        },
                        new
                        {
                            Id = 10,
                            Text = "Testing"
                        });
                });

            modelBuilder.Entity("QuickPicSurvey.Domain.Models.Respondent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Respondents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Firstname = "John",
                            Lastname = "Smith",
                            Password = "password",
                            Username = "u1"
                        },
                        new
                        {
                            Id = 2,
                            Firstname = "Susan",
                            Lastname = "Birnam",
                            Password = "password",
                            Username = "u2"
                        },
                        new
                        {
                            Id = 3,
                            Firstname = "Carter",
                            Lastname = "Flamings",
                            Password = "password",
                            Username = "u3"
                        },
                        new
                        {
                            Id = 4,
                            Firstname = "Elrond",
                            Lastname = "Raven",
                            Password = "password",
                            Username = "u4"
                        },
                        new
                        {
                            Id = 5,
                            Firstname = "Frodo",
                            Lastname = "Smitherns",
                            Password = "password",
                            Username = "u5"
                        });
                });

            modelBuilder.Entity("QuickPicSurvey.Domain.Models.RespondentResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Answer")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("RespondentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("RespondentId");

                    b.ToTable("RespondentResults");
                });

            modelBuilder.Entity("QuickPicSurvey.Domain.Models.Objective", b =>
                {
                    b.HasOne("QuickPicSurvey.Domain.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuickPicSurvey.Domain.Models.RespondentResult", b =>
                {
                    b.HasOne("QuickPicSurvey.Domain.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickPicSurvey.Domain.Models.Respondent", "Respondent")
                        .WithMany()
                        .HasForeignKey("RespondentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Respondent");
                });
#pragma warning restore 612, 618
        }
    }
}
