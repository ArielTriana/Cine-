﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210611024135_Segunda")]
    partial class Segunda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("DomainLayer.Apply", b =>
                {
                    b.Property<int>("TicketPurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DiscountListId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("TicketPurchaseScheduleEndTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TicketPurchaseScheduleStartTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("TicketPurchaseSeatCinemaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicketPurchaseSeatId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TicketPurchaseId");

                    b.HasIndex("DiscountListId");

                    b.HasIndex("TicketPurchaseSeatCinemaId", "TicketPurchaseSeatId", "TicketPurchaseScheduleStartTime", "TicketPurchaseScheduleEndTime");

                    b.ToTable("Apply");
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

                    b.Property<float>("SeatPrice")
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

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("DomainLayer.Partner", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<long>("Points")
                        .HasColumnType("INTEGER");

                    b.HasKey("Code");

                    b.ToTable("Partner");
                });

            modelBuilder.Entity("DomainLayer.Purchase", b =>
                {
                    b.Property<int>("TicketPurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PartnerCode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PointsSpent")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TicketPurchaseScheduleEndTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TicketPurchaseScheduleStartTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("TicketPurchaseSeatCinemaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicketPurchaseSeatId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TicketPurchaseId");

                    b.HasIndex("PartnerCode");

                    b.HasIndex("TicketPurchaseSeatCinemaId", "TicketPurchaseSeatId", "TicketPurchaseScheduleStartTime", "TicketPurchaseScheduleEndTime");

                    b.ToTable("Purchase");
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
                    b.Property<int>("SeatCinemaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeatId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ScheduleStartTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ScheduleEndTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SeatCinemaId", "SeatId", "ScheduleStartTime", "ScheduleEndTime");

                    b.HasIndex("ScheduleStartTime", "ScheduleEndTime");

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

            modelBuilder.Entity("DomainLayer.OnlineTickectPurchase", b =>
                {
                    b.HasBaseType("DomainLayer.TicketPurchase");

                    b.Property<string>("CreditCard")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("OnlineTickectPurchase");
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

            modelBuilder.Entity("DomainLayer.Apply", b =>
                {
                    b.HasOne("DomainLayer.DiscountList", "DiscountList")
                        .WithMany()
                        .HasForeignKey("DiscountListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.TicketPurchase", "TicketPurchase")
                        .WithMany()
                        .HasForeignKey("TicketPurchaseSeatCinemaId", "TicketPurchaseSeatId", "TicketPurchaseScheduleStartTime", "TicketPurchaseScheduleEndTime")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiscountList");

                    b.Navigation("TicketPurchase");
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

            modelBuilder.Entity("DomainLayer.Purchase", b =>
                {
                    b.HasOne("DomainLayer.Partner", "Partner")
                        .WithMany()
                        .HasForeignKey("PartnerCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.TicketPurchase", "TicketPurchase")
                        .WithMany()
                        .HasForeignKey("TicketPurchaseSeatCinemaId", "TicketPurchaseSeatId", "TicketPurchaseScheduleStartTime", "TicketPurchaseScheduleEndTime")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Partner");

                    b.Navigation("TicketPurchase");
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
                    b.HasOne("DomainLayer.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleStartTime", "ScheduleEndTime")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatCinemaId", "SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

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
#pragma warning restore 612, 618
        }
    }
}
