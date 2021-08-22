﻿// <auto-generated />
using BackgroundEmailSenderSample.Models.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace background_email_sender_master.Migrations
{
    [DbContext(typeof(MyEmailSenderDbContext))]
    [Migration("20210808185217_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("BackgroundEmailSender_EFCore.Models.Entities.Email", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<string>("Recipient")
                        .HasColumnType("TEXT");

                    b.Property<int>("SenderCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EmailMessage");
                });
#pragma warning restore 612, 618
        }
    }
}