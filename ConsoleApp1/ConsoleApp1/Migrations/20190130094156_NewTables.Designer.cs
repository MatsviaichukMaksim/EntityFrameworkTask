﻿// <auto-generated />
using System;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20190130094156_NewTables")]
    partial class NewTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp1.Models.Award", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Date");

                    b.Property<int?>("GetterId");

                    b.Property<int?>("GiverId");

                    b.Property<int>("Points");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GetterId");

                    b.HasIndex("GiverId");

                    b.ToTable("Awards");
                });

            modelBuilder.Entity("ConsoleApp1.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date");

                    b.Property<int>("Points");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ConsoleApp1.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AwardId");

                    b.Property<string>("Date");

                    b.Property<string>("Text");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AwardId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ConsoleApp1.Models.Like", b =>
                {
                    b.Property<int>("AwardId");

                    b.Property<int>("UserId");

                    b.Property<string>("Date");

                    b.HasKey("AwardId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("ConsoleApp1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ConsoleApp1.Models.Award", b =>
                {
                    b.HasOne("ConsoleApp1.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleApp1.Models.User", "Getter")
                        .WithMany()
                        .HasForeignKey("GetterId");

                    b.HasOne("ConsoleApp1.Models.User", "Giver")
                        .WithMany()
                        .HasForeignKey("GiverId");
                });

            modelBuilder.Entity("ConsoleApp1.Models.Comment", b =>
                {
                    b.HasOne("ConsoleApp1.Models.Award", "Award")
                        .WithMany()
                        .HasForeignKey("AwardId");

                    b.HasOne("ConsoleApp1.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ConsoleApp1.Models.Like", b =>
                {
                    b.HasOne("ConsoleApp1.Models.Award", "Award")
                        .WithMany()
                        .HasForeignKey("AwardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleApp1.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
