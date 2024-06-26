﻿// <auto-generated />
using System;
using BMSClone.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BMSClone.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BMSClone.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("cities");
                });

            modelBuilder.Entity("BMSClone.Models.Hall", b =>
                {
                    b.Property<int>("HallId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HallId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TheatreId")
                        .HasColumnType("int");

                    b.HasKey("HallId");

                    b.HasIndex("TheatreId");

                    b.ToTable("halls");
                });

            modelBuilder.Entity("BMSClone.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("BMSClone.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("MovieId");

                    b.ToTable("movies");
                });

            modelBuilder.Entity("BMSClone.Models.MovieLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("MovieId");

                    b.ToTable("movieLanguages");
                });

            modelBuilder.Entity("BMSClone.Models.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeatId"), 1L, 1);

                    b.Property<int>("hallId")
                        .HasColumnType("int");

                    b.Property<int>("seatNumber")
                        .HasColumnType("int");

                    b.Property<string>("seatType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeatId");

                    b.HasIndex("hallId");

                    b.ToTable("seats");
                });

            modelBuilder.Entity("BMSClone.Models.Show", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowId"), 1L, 1);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("duration")
                        .HasColumnType("int");

                    b.Property<int>("hallid")
                        .HasColumnType("int");

                    b.Property<DateTime>("start")
                        .HasColumnType("datetime2");

                    b.Property<int>("theatreId")
                        .HasColumnType("int");

                    b.HasKey("ShowId");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.HasIndex("hallid");

                    b.HasIndex("theatreId");

                    b.ToTable("shows");
                });

            modelBuilder.Entity("BMSClone.Models.ShowSeats", b =>
                {
                    b.Property<int>("ShowSeatsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowSeatsId"), 1L, 1);

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShowSeatsId");

                    b.HasIndex("SeatId");

                    b.HasIndex("ShowId");

                    b.ToTable("showSeats");
                });

            modelBuilder.Entity("BMSClone.Models.Theatre", b =>
                {
                    b.Property<int>("TheatreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TheatreId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.HasKey("TheatreId");

                    b.HasIndex("cityId");

                    b.ToTable("theatres");
                });

            modelBuilder.Entity("BMSClone.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BMSClone.Models.Hall", b =>
                {
                    b.HasOne("BMSClone.Models.Theatre", "theatre")
                        .WithMany("halls")
                        .HasForeignKey("TheatreId")
                        .IsRequired();

                    b.Navigation("theatre");
                });

            modelBuilder.Entity("BMSClone.Models.MovieLanguage", b =>
                {
                    b.HasOne("BMSClone.Models.Language", "language")
                        .WithMany("MovieLanguages")
                        .HasForeignKey("LanguageId")
                        .IsRequired();

                    b.HasOne("BMSClone.Models.Movie", "movie")
                        .WithMany("MovieLanguages")
                        .HasForeignKey("MovieId")
                        .IsRequired();

                    b.Navigation("language");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("BMSClone.Models.Seat", b =>
                {
                    b.HasOne("BMSClone.Models.Hall", "hall")
                        .WithMany("seats")
                        .HasForeignKey("hallId")
                        .IsRequired();

                    b.Navigation("hall");
                });

            modelBuilder.Entity("BMSClone.Models.Show", b =>
                {
                    b.HasOne("BMSClone.Models.Movie", "movie")
                        .WithOne("show")
                        .HasForeignKey("BMSClone.Models.Show", "MovieId")
                        .IsRequired();

                    b.HasOne("BMSClone.Models.Hall", "hall")
                        .WithMany("show")
                        .HasForeignKey("hallid")
                        .IsRequired();

                    b.HasOne("BMSClone.Models.Theatre", "theatre")
                        .WithMany("shows")
                        .HasForeignKey("theatreId")
                        .IsRequired();

                    b.Navigation("hall");

                    b.Navigation("movie");

                    b.Navigation("theatre");
                });

            modelBuilder.Entity("BMSClone.Models.ShowSeats", b =>
                {
                    b.HasOne("BMSClone.Models.Seat", "seat")
                        .WithMany("showSeats")
                        .HasForeignKey("SeatId")
                        .IsRequired();

                    b.HasOne("BMSClone.Models.Show", "show")
                        .WithMany("showSeats")
                        .HasForeignKey("ShowId")
                        .IsRequired();

                    b.Navigation("seat");

                    b.Navigation("show");
                });

            modelBuilder.Entity("BMSClone.Models.Theatre", b =>
                {
                    b.HasOne("BMSClone.Models.City", "City")
                        .WithMany("theatres")
                        .HasForeignKey("cityId")
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("BMSClone.Models.City", b =>
                {
                    b.Navigation("theatres");
                });

            modelBuilder.Entity("BMSClone.Models.Hall", b =>
                {
                    b.Navigation("seats");

                    b.Navigation("show");
                });

            modelBuilder.Entity("BMSClone.Models.Language", b =>
                {
                    b.Navigation("MovieLanguages");
                });

            modelBuilder.Entity("BMSClone.Models.Movie", b =>
                {
                    b.Navigation("MovieLanguages");

                    b.Navigation("show")
                        .IsRequired();
                });

            modelBuilder.Entity("BMSClone.Models.Seat", b =>
                {
                    b.Navigation("showSeats");
                });

            modelBuilder.Entity("BMSClone.Models.Show", b =>
                {
                    b.Navigation("showSeats");
                });

            modelBuilder.Entity("BMSClone.Models.Theatre", b =>
                {
                    b.Navigation("halls");

                    b.Navigation("shows");
                });
#pragma warning restore 612, 618
        }
    }
}
