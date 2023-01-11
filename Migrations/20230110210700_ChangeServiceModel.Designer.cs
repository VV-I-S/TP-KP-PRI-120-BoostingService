﻿// <auto-generated />
using System;
using BoostingService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoostingService.Migrations
{
    [DbContext(typeof(BoostContext))]
    [Migration("20230110210700_ChangeServiceModel")]
    partial class ChangeServiceModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoostingService.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("boosterid")
                        .HasColumnType("int");

                    b.Property<int>("cost")
                        .HasColumnType("int");

                    b.Property<int>("countLP")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateOfCreate")
                        .HasColumnType("datetime2");

                    b.Property<int>("endMMR")
                        .HasColumnType("int");

                    b.Property<int?>("idBooster")
                        .HasColumnType("int");

                    b.Property<int?>("idService")
                        .HasColumnType("int");

                    b.Property<int?>("idUser")
                        .HasColumnType("int");

                    b.Property<int?>("serviceid")
                        .HasColumnType("int");

                    b.Property<int>("startMMR")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("boosterid");

                    b.HasIndex("serviceid");

                    b.HasIndex("userid");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BoostingService.Models.Service", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cost")
                        .HasColumnType("int");

                    b.Property<int>("discount")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("BoostingService.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BoostingService.Models.Order", b =>
                {
                    b.HasOne("BoostingService.Models.User", "booster")
                        .WithMany()
                        .HasForeignKey("boosterid");

                    b.HasOne("BoostingService.Models.Service", "service")
                        .WithMany()
                        .HasForeignKey("serviceid");

                    b.HasOne("BoostingService.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userid");

                    b.Navigation("booster");

                    b.Navigation("service");

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
