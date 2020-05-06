﻿// <auto-generated />
using Fardin.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fardin.DataLayer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Fardin.DataLayer.Entites.DetailsDescription", b =>
                {
                    b.Property<int>("DetailsDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PostDetailId");

                    b.Property<int>("PostDetailsId");

                    b.Property<string>("Text");

                    b.Property<string>("imageName");

                    b.Property<string>("videoName");

                    b.HasKey("DetailsDescriptionId");

                    b.HasIndex("PostDetailId");

                    b.ToTable("detailsDescriptions");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminPanelId");

                    b.Property<string>("PostImg");

                    b.Property<string>("PostText");

                    b.Property<int>("SectionId");

                    b.Property<string>("Title");

                    b.HasKey("PostId");

                    b.HasIndex("AdminPanelId");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.PostDetail", b =>
                {
                    b.Property<string>("PostDetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageName");

                    b.Property<int>("PostId");

                    b.Property<string>("TextResumen");

                    b.Property<string>("Title");

                    b.HasKey("PostDetailId");

                    b.HasIndex("PostId");

                    b.ToTable("postDetails");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.DetailsDescription", b =>
                {
                    b.HasOne("Fardin.DataLayer.Entites.PostDetail", "postDetail")
                        .WithMany("detailsDescriptions")
                        .HasForeignKey("PostDetailId");
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.Post", b =>
                {
                    b.HasOne("Fardin.DataLayer.Entites.AdminPanel", "adminPanel")
                        .WithMany("Posts")
                        .HasForeignKey("AdminPanelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fardin.DataLayer.Entites.PostDetail", b =>
                {
                    b.HasOne("Fardin.DataLayer.Entites.Post", "post")
                        .WithMany("postDetails")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}