﻿// <auto-generated />
using Fardin.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fardin.DataLayer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200607172231_fixDescriptiom")]
    partial class fixDescriptiom
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fardin.DataLayer.Entites.AdminPanel", b =>
                {
                    b.Property<int>("AdminPanelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.Property<string>("imgName");

                    b.HasKey("AdminPanelId");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Image");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Text");

                    b.Property<string>("Username");

                    b.Property<bool>("isComment");

                    b.Property<bool>("isPublic");

                    b.HasKey("CommentId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.ContactUs", b =>
                {
                    b.Property<int>("ContactUsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Text");

                    b.HasKey("ContactUsId");

                    b.ToTable("contacts");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.ImageGallery", b =>
                {
                    b.Property<int>("ImageGalleryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName");

                    b.Property<int>("postId");

                    b.HasKey("ImageGalleryId");

                    b.HasIndex("postId");

                    b.ToTable("imageGalleries");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminPanelId");

                    b.Property<int>("Language_Id");

                    b.Property<string>("PostImg");

                    b.Property<string>("PostText");

                    b.Property<int>("SectionId");

                    b.Property<string>("Title");

                    b.Property<string>("languageName");

                    b.HasKey("PostId");

                    b.HasIndex("AdminPanelId");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.SubPost", b =>
                {
                    b.Property<int>("SubPostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName");

                    b.Property<int>("PostId");

                    b.Property<string>("TextResumen");

                    b.Property<string>("Title");

                    b.Property<int>("subPostDescriptionId");

                    b.HasKey("SubPostId");

                    b.HasIndex("PostId");

                    b.ToTable("subPosts");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.SubPostDescription", b =>
                {
                    b.Property<int>("SubPostDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubPostId");

                    b.Property<string>("Text");

                    b.Property<string>("imageName");

                    b.HasKey("SubPostDescriptionId");

                    b.HasIndex("SubPostId")
                        .IsUnique();

                    b.ToTable("subPostDescriptions");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.ImageGallery", b =>
                {
                    b.HasOne("Fardin.DataLayer.Entites.Post", "post")
                        .WithMany("imageGalleries")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.Post", b =>
                {
                    b.HasOne("Fardin.DataLayer.Entites.AdminPanel", "adminPanel")
                        .WithMany("Posts")
                        .HasForeignKey("AdminPanelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.SubPost", b =>
                {
                    b.HasOne("Fardin.DataLayer.Entites.Post", "post")
                        .WithMany("SubPosts")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.SubPostDescription", b =>
                {
                    b.HasOne("Fardin.DataLayer.Entites.SubPost", "SubPost")
                        .WithOne("subPostDescription")
                        .HasForeignKey("Fardin.DataLayer.Entites.SubPostDescription", "SubPostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
