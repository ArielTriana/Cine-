﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<int>("ActorsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoviesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ActorsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("ActorMovie");
                });

            modelBuilder.Entity("CountryMovie", b =>
                {
                    b.Property<int>("CountriesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoviesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CountriesId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CountryMovie");
                });

            modelBuilder.Entity("DiscountDiscountList", b =>
                {
                    b.Property<int>("DiscountListsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DiscountsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DiscountListsId", "DiscountsId");

                    b.HasIndex("DiscountsId");

                    b.ToTable("DiscountDiscountList");
                });

            modelBuilder.Entity("DomainLayer.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("DomainLayer.Batch", b =>
                {
                    b.Property<int>("CinemaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ScheduleStartTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ScheduleEndTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("TicketPoints")
                        .HasColumnType("REAL");

                    b.Property<float>("TicketPrice")
                        .HasColumnType("REAL");

                    b.HasKey("CinemaId", "ScheduleStartTime", "ScheduleEndTime");

                    b.HasIndex("MovieId");

                    b.HasIndex("ScheduleStartTime", "ScheduleEndTime");

                    b.ToTable("Batch");
                });

            modelBuilder.Entity("DomainLayer.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("DomainLayer.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("DomainLayer.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("DiscountedMoney")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("DomainLayer.DiscountList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("TotalDiscounted")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("DiscountList");
                });

            modelBuilder.Entity("DomainLayer.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("DomainLayer.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RatingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RatingId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("DomainLayer.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("DomainLayer.Schedule", b =>
                {
                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.HasKey("StartTime", "EndTime");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("DomainLayer.Seat", b =>
                {
                    b.Property<int>("CinemaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("CinemaId", "Id");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("DomainLayer.TicketPurchase", b =>
                {
                    b.Property<int>("CinemaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BatchScheduleStartTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BatchScheduleEndTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("SeatId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AppUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<int>("DiscountListId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Paid")
                        .HasColumnType("INTEGER");

                    b.Property<float>("PointsSpent")
                        .HasColumnType("REAL");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("TimeReserve")
                        .HasColumnType("TEXT");

                    b.HasKey("CinemaId", "BatchScheduleStartTime", "BatchScheduleEndTime", "SeatId");

                    b.HasIndex("DiscountListId");

                    b.HasIndex("CinemaId", "SeatId");

                    b.ToTable("TicketPurchase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TicketPurchase");
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoviesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GenresId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("DomainLayer.OnlineTicketPurchase", b =>
                {
                    b.HasBaseType("DomainLayer.TicketPurchase");

                    b.Property<string>("CreditCard")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("OnlineTicketPurchase");
                });

            modelBuilder.Entity("DomainLayer.PhysicalTicketPurchase", b =>
                {
                    b.HasBaseType("DomainLayer.TicketPurchase");

                    b.HasDiscriminator().HasValue("PhysicalTicketPurchase");
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("DomainLayer.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CountryMovie", b =>
                {
                    b.HasOne("DomainLayer.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DiscountDiscountList", b =>
                {
                    b.HasOne("DomainLayer.DiscountList", null)
                        .WithMany()
                        .HasForeignKey("DiscountListsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Discount", null)
                        .WithMany()
                        .HasForeignKey("DiscountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DomainLayer.Batch", b =>
                {
                    b.HasOne("DomainLayer.Cinema", "Cinema")
                        .WithMany()
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Movie", "Movie")
                        .WithMany("Batches")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleStartTime", "ScheduleEndTime")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Movie");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("DomainLayer.Movie", b =>
                {
                    b.HasOne("DomainLayer.Rating", "Rating")
                        .WithMany("Movies")
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("DomainLayer.Seat", b =>
                {
                    b.HasOne("DomainLayer.Cinema", "Cinema")
                        .WithMany("Seats")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("DomainLayer.TicketPurchase", b =>
                {
                    b.HasOne("DomainLayer.DiscountList", "DiscountList")
                        .WithMany()
                        .HasForeignKey("DiscountListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("CinemaId", "SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("CinemaId", "BatchScheduleStartTime", "BatchScheduleEndTime")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batch");

                    b.Navigation("DiscountList");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("DomainLayer.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DomainLayer.Cinema", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("DomainLayer.Movie", b =>
                {
                    b.Navigation("Batches");
                });

            modelBuilder.Entity("DomainLayer.Rating", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
