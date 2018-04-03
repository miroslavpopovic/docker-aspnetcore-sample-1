﻿// <auto-generated />
using System;
using BoardGames.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace BoardGames.Api.Data.Migrations
{
    [DbContext(typeof(GamesDbContext))]
    [Migration("20180403204657_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.0-preview1-28290");

            modelBuilder.Entity("BoardGames.Api.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnName("age")
                        .HasColumnType("text");

                    b.Property<string>("Designer")
                        .IsRequired()
                        .HasColumnName("designer")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnName("image")
                        .HasColumnType("text");

                    b.Property<string>("Players")
                        .IsRequired()
                        .HasColumnName("players")
                        .HasColumnType("text");

                    b.Property<string>("PlayingTime")
                        .IsRequired()
                        .HasColumnName("playing_time")
                        .HasColumnType("text");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnName("publisher")
                        .HasColumnType("text");

                    b.Property<decimal>("Rating")
                        .HasColumnName("rating");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("text");

                    b.Property<string>("Types")
                        .IsRequired()
                        .HasColumnName("types")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("url")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnName("year");

                    b.HasKey("Id")
                        .HasName("pk_game");

                    b.ToTable("game");
                });
#pragma warning restore 612, 618
        }
    }
}
