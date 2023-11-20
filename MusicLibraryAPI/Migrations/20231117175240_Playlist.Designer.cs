﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicLibraryAPI.Data;

#nullable disable

namespace MusicLibraryAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231117175240_Playlist")]
    partial class Playlist
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MusicLibraryAPI.Models.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Playlist");
                });

            modelBuilder.Entity("MusicLibraryAPI.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Album")
                        .HasColumnType("longtext");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int?>("PlaylistId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PlaylistId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album = "x Infinity",
                            Artist = "Watsky",
                            Genre = "Rap",
                            Likes = 33000,
                            ReleaseDate = new DateTime(2016, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Talking to Myself"
                        },
                        new
                        {
                            Id = 2,
                            Artist = "The Living Tombstone",
                            Genre = "Electronic",
                            Likes = 155000,
                            ReleaseDate = new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hit The Snooze"
                        },
                        new
                        {
                            Id = 3,
                            Album = "Dogma Resistance",
                            Artist = "RIOT",
                            Genre = "Electronic",
                            Likes = 248000,
                            ReleaseDate = new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Overkill"
                        },
                        new
                        {
                            Id = 4,
                            Album = "Blackmagik Blazing",
                            Artist = "Camellia",
                            Genre = "Electronic",
                            Likes = 10000,
                            ReleaseDate = new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "SECRET BOSS"
                        },
                        new
                        {
                            Id = 5,
                            Artist = "ELEPS",
                            Genre = "Electronic",
                            Likes = 1600,
                            ReleaseDate = new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Vainilla"
                        });
                });

            modelBuilder.Entity("MusicLibraryAPI.Models.Song", b =>
                {
                    b.HasOne("MusicLibraryAPI.Models.Playlist", "Playlist")
                        .WithMany("Songs")
                        .HasForeignKey("PlaylistId");

                    b.Navigation("Playlist");
                });

            modelBuilder.Entity("MusicLibraryAPI.Models.Playlist", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
