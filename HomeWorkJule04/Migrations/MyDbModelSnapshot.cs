﻿// <auto-generated />
using System;
using HomeWorkJule04.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeWorkJule04.Migrations
{
    [DbContext(typeof(MyDb))]
    partial class MyDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeWorkJule04.Models.AboutMe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BigImage");

                    b.Property<string>("Content");

                    b.Property<string>("LitleImage");

                    b.HasKey("Id");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("HomeWorkJule04.Models.Features", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("HomeWorkJule04.Models.HappyCostumer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Commet");

                    b.Property<string>("Name");

                    b.Property<string>("img");

                    b.HasKey("Id");

                    b.ToTable("HappyCostumers");
                });

            modelBuilder.Entity("HomeWorkJule04.Models.PopularDes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("BgImage");

                    b.Property<string>("Price");

                    b.HasKey("Id");

                    b.ToTable("PopularDess");
                });

            modelBuilder.Entity("HomeWorkJule04.Models.RecentBlog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("RecentBlog");
                });

            modelBuilder.Entity("HomeWorkJule04.Models.RecentBlogContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasMaxLength(200);

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("img")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("RecentBlogContents");
                });

            modelBuilder.Entity("HomeWorkJule04.Models.Slide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BgImage")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Heading");

                    b.Property<string>("HeadingDetail");

                    b.HasKey("Id");

                    b.ToTable("Slides");
                });
#pragma warning restore 612, 618
        }
    }
}