using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ScottModel.Models;

namespace src.Migrations
{
    [DbContext(typeof(BloggingDbContext))]
    [Migration("20160222033217_Version2")]
    partial class Version2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScottBlog.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("BlogId");
                });

            modelBuilder.Entity("ScottBlog.Models.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogID");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("PostID");
                });

            modelBuilder.Entity("ScottBlog.Models.Post", b =>
                {
                    b.HasOne("ScottBlog.Models.Blog")
                        .WithMany()
                        .HasForeignKey("BlogID");
                });
        }
    }
}
