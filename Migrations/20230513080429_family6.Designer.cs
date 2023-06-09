﻿// <auto-generated />
using System;
using CatBD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CatBD.Migrations
{
    [DbContext(typeof(ApplicationDBcontext))]
    [Migration("20230513080429_family6")]
    partial class family6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CatBD.BreedCharacteristics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Adaptabiliti")
                        .HasColumnType("integer");

                    b.Property<int>("AttachmentTofamily")
                        .HasColumnType("integer");

                    b.Property<int>("FriendlinessForChildren")
                        .HasColumnType("integer");

                    b.Property<int>("FriendlyToDogs")
                        .HasColumnType("integer");

                    b.Property<int>("GameActivity")
                        .HasColumnType("integer");

                    b.Property<int>("GeneralHealth")
                        .HasColumnType("integer");

                    b.Property<int>("HairLoss")
                        .HasColumnType("integer");

                    b.Property<int>("Intelligence")
                        .HasColumnType("integer");

                    b.Property<int>("LoveForMeow")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("breedCharacteristics");
                });

            modelBuilder.Entity("CatBD.Famyly", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacteristicId")
                        .HasColumnType("integer");

                    b.Property<string>("FamylyName")
                        .HasColumnType("text");

                    b.Property<int?>("InformationId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CharacteristicId");

                    b.HasIndex("InformationId");

                    b.ToTable("famylies");
                });

            modelBuilder.Entity("CatBD.InformationAboutTheBreed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CoatType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CountryOfOrigin")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LifeExpectancy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lifestyle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Weight_kg")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("infoAboutTheBreeds");
                });

            modelBuilder.Entity("CatBD.Famyly", b =>
                {
                    b.HasOne("CatBD.BreedCharacteristics", "Characteristic")
                        .WithMany()
                        .HasForeignKey("CharacteristicId");

                    b.HasOne("CatBD.InformationAboutTheBreed", "Information")
                        .WithMany()
                        .HasForeignKey("InformationId");

                    b.Navigation("Characteristic");

                    b.Navigation("Information");
                });
#pragma warning restore 612, 618
        }
    }
}
