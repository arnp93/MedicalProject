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
    [Migration("20200523154928_addComments")]
    partial class addComments
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

                    b.Property<string>("Username");

                    b.Property<bool>("isComment");

                    b.Property<bool>("isPublic");

                    b.Property<string>("text");

                    b.HasKey("CommentId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.DetailsDescription", b =>
                {
                    b.Property<int>("DetailsDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubPostId");

                    b.Property<string>("Text");

                    b.Property<string>("imageName");

                    b.HasKey("DetailsDescriptionId");

                    b.HasIndex("SubPostId");

                    b.ToTable("subPostDescription");
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

                    b.HasKey("SubPostId");

                    b.HasIndex("PostId");

                    b.ToTable("SubPosts");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.DetailsDescription", b =>
                {
                    b.HasOne("Fardin.DataLayer.Entites.SubPost", "SubPost")
                        .WithMany("subPostDescription")
                        .HasForeignKey("SubPostId")
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
#pragma warning restore 612, 618
        }
    }
}
