﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Reddit.Entities;
using System;

namespace Reddit.Migrations
{
    [DbContext(typeof(PostContext))]
    partial class PostContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Reddit.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OwnerId");

                    b.Property<int>("Score");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("PostList");
                });

            modelBuilder.Entity("Reddit.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("UserList");
                });

            modelBuilder.Entity("Reddit.Models.Post", b =>
                {
                    b.HasOne("Reddit.Models.User", "Owner")
                        .WithMany("Posts")
                        .HasForeignKey("OwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}