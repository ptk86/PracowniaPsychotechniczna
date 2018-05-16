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
    [Migration("20180516185949_ChangeCenaPropertyToInteger")]
    partial class ChangeCenaPropertyToInteger
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

                    b.Property<int?>("FrimaBadanegoId");

                    b.Property<int>("PsychologId");

                    b.Property<int>("TypBadaniaId");

                    b.HasKey("Id");

                    b.HasIndex("BadanyId");

                    b.HasIndex("FrimaBadanegoId");

                    b.HasIndex("PsychologId");

                    b.HasIndex("TypBadaniaId");

                    b.ToTable("Badanies");
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.Badany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adres")
                        .IsRequired();

                    b.Property<string>("Imie")
                        .IsRequired();

                    b.Property<string>("Nazwisko")
                        .IsRequired();

                    b.Property<string>("Pesel")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Badany");
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.Firma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adres")
                        .IsRequired();

                    b.Property<string>("Nazwa")
                        .IsRequired();

                    b.Property<string>("Nip")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Firma");
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.Psycholog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Imie")
                        .IsRequired();

                    b.Property<string>("Nazwisko")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Psycholog");
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.TypBadania", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cena");

                    b.Property<string>("Nazwa")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TypBadania");
                });

            modelBuilder.Entity("PracowniaPsychotechniczna.Model.Badanie", b =>
                {
                    b.HasOne("PracowniaPsychotechniczna.Model.Badany", "Badany")
                        .WithMany()
                        .HasForeignKey("BadanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PracowniaPsychotechniczna.Model.Firma", "FrimaBadanego")
                        .WithMany()
                        .HasForeignKey("FrimaBadanegoId");

                    b.HasOne("PracowniaPsychotechniczna.Model.Psycholog", "Psycholog")
                        .WithMany()
                        .HasForeignKey("PsychologId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PracowniaPsychotechniczna.Model.TypBadania", "TypBadania")
                        .WithMany()
                        .HasForeignKey("TypBadaniaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
