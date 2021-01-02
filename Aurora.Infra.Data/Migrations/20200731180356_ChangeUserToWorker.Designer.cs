﻿// <auto-generated />
using System;
using Aurora.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aurora.Infra.Data.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20200731180356_ChangeUserToWorker")]
    partial class ChangeUserToWorker
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Aurora.Domain.Entities.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnName("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nin")
                        .IsRequired()
                        .HasColumnName("Nin")
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("Password")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Worker");
                });
#pragma warning restore 612, 618
        }
    }
}
