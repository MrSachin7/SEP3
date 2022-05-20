﻿// <auto-generated />
using System;
using EFC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFC.Migrations
{
    [DbContext(typeof(DbAccess))]
    [Migration("20220514205800_fix1")]
    partial class fix1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Bookmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PostId")
                        .HasColumnType("integer");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("Username");

                    b.ToTable("Bookmarks");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entities.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("DateCreated")
                        .HasColumnType("date");

                    b.Property<int>("PostId")
                        .HasColumnType("integer");

                    b.Property<string>("WriterUsername")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("WriterUsername");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Entities.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PostId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Entities.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Condition")
                        .HasColumnType("text");

                    b.Property<DateOnly>("DateCreated")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int?>("SubcategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WriterUsername")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SubcategoryId");

                    b.HasIndex("WriterUsername");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Entities.Models.Report", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("integer");

                    b.Property<int>("ReporterUsername")
                        .HasColumnType("integer");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PostId", "ReporterUsername");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Entities.Models.Subcategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Models.Bookmark", b =>
                {
                    b.HasOne("Entities.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("BookmarkedPosts")
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.Comment", b =>
                {
                    b.HasOne("Entities.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "Writer")
                        .WithMany()
                        .HasForeignKey("WriterUsername")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("Entities.Models.Image", b =>
                {
                    b.HasOne("Entities.Models.Post", null)
                        .WithMany("Images")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("Entities.Models.Post", b =>
                {
                    b.HasOne("Entities.Models.Subcategory", "Subcategory")
                        .WithMany("Posts")
                        .HasForeignKey("SubcategoryId");

                    b.HasOne("Entities.Models.User", "Writer")
                        .WithMany("Posts")
                        .HasForeignKey("WriterUsername");

                    b.Navigation("Subcategory");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("Entities.Models.Subcategory", b =>
                {
                    b.HasOne("Entities.Models.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Navigation("Subcategories");
                });

            modelBuilder.Entity("Entities.Models.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("Entities.Models.Subcategory", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Navigation("BookmarkedPosts");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
