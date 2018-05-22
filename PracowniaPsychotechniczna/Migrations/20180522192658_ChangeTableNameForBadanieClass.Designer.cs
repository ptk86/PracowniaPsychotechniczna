﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PracowniaPsychotechniczna.Dal;
using System;

namespace PracowniaPsychotechniczna.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180522192658_ChangeTableNameForBadanieClass")]
    partial class ChangeTableNameForBadanieClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.Badanie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BadanyId");

                    b.Property<DateTime>("DataBadania");

                    b.Property<int>("PsychologId");

                    b.Property<int>("TypBadaniaId");

                    b.HasKey("Id");

                    b.HasIndex("BadanyId");

                    b.HasIndex("PsychologId");

                    b.HasIndex("TypBadaniaId");

                    b.ToTable("Badanie");
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.Badany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adres");

                    b.Property<string>("Imie");

                    b.Property<string>("Nazwisko");

                    b.Property<string>("Pesel");

                    b.HasKey("Id");

                    b.HasIndex("Pesel")
                        .IsUnique()
                        .HasFilter("[Pesel] IS NOT NULL");

                    b.ToTable("Badany");
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.Firma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adres");

                    b.Property<string>("Nazwa");

                    b.Property<string>("Nip");

                    b.HasKey("Id");

                    b.HasIndex("Nip")
                        .IsUnique()
                        .HasFilter("[Nip] IS NOT NULL");

                    b.ToTable("Firma");
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.FirmaBadanie", b =>
                {
                    b.Property<int>("FirmaId");

                    b.Property<int>("BadanieId");

                    b.HasKey("FirmaId", "BadanieId");

                    b.HasIndex("BadanieId")
                        .IsUnique();

                    b.ToTable("FirmaBadanie");
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.Psycholog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Imie");

                    b.Property<string>("Nazwisko");

                    b.HasKey("Id");

                    b.ToTable("Psycholog");
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.TypBadania", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cena");

                    b.Property<string>("Nazwa");

                    b.HasKey("Id");

                    b.ToTable("TypBadania");
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.Badanie", b =>
                {
                    b.HasOne("PracowniaPsychotechniczna.Model.Badany", "Badany")
                        .WithMany()
                        .HasForeignKey("BadanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PracowniaPsychotechniczna.Model.Psycholog", "Psycholog")
                        .WithMany()
                        .HasForeignKey("PsychologId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PracowniaPsychotechniczna.Model.TypBadania", "TypBadania")
                        .WithMany()
                        .HasForeignKey("TypBadaniaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.FirmaBadanie", b =>
                {
                    b.HasOne("PracowniaPsychotechniczna.Model.Badanie", "Badanie")
                        .WithOne("FirmaBadanie")
                        .HasForeignKey("PracowniaPsychotechniczna.Model.FirmaBadanie", "BadanieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PracowniaPsychotechniczna.Model.Firma", "Firma")
                        .WithMany("FirmaBadanieList")
                        .HasForeignKey("FirmaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
