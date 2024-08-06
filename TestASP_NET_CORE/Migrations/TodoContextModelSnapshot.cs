﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestASP_NET_CORE.Data;

#nullable disable

namespace TestASP_NET_CORE.Migrations
{
    [DbContext(typeof(TodoContext))]
    partial class TodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestASP_NET_CORE.Data.Task", b =>
                {
                    b.Property<int>("_taskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("_taskId"));

                    b.Property<DateTime>("_date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("_isDone")
                        .HasColumnType("bit");

                    b.Property<string>("_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("_userId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("_taskId");

                    b.ToTable("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
