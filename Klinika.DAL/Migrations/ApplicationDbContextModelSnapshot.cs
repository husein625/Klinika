﻿// <auto-generated />
using System;
using Klinika.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Klinika.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Klinika.DAL.Models.Ljekar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sifra")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("TitulaID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitulaID");

                    b.ToTable("Ljekar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 353, DateTimeKind.Utc).AddTicks(5823),
                            CreatedBy = "hmuftic",
                            Ime = "Husein",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Prezime = "Muftic",
                            Sifra = 1,
                            TitulaID = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 353, DateTimeKind.Utc).AddTicks(5891),
                            CreatedBy = "hmuftic",
                            Ime = "Edin",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Prezime = "Malcinovic",
                            Sifra = 2,
                            TitulaID = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 353, DateTimeKind.Utc).AddTicks(5894),
                            CreatedBy = "hmuftic",
                            Ime = "Ahmed",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Prezime = "Sehovic",
                            Sifra = 3,
                            TitulaID = 3
                        });
                });

            modelBuilder.Entity("Klinika.DAL.Models.Nalaz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumVrijeme")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrijemID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrijemID");

                    b.ToTable("Nalaz");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 355, DateTimeKind.Utc).AddTicks(2987),
                            CreatedBy = "hmuftic",
                            DatumVrijeme = new DateTime(2021, 1, 25, 19, 59, 11, 355, DateTimeKind.Utc).AddTicks(3468),
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Opis = "OpisNalaza",
                            PrijemID = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 355, DateTimeKind.Utc).AddTicks(4427),
                            CreatedBy = "hmuftic",
                            DatumVrijeme = new DateTime(2021, 1, 25, 19, 59, 11, 355, DateTimeKind.Utc).AddTicks(4437),
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Opis = "OpisNalaza",
                            PrijemID = 2
                        });
                });

            modelBuilder.Entity("Klinika.DAL.Models.Pacijent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRođenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImePrezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("SpolID")
                        .HasColumnType("int");

                    b.Property<int?>("Telefon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpolID");

                    b.ToTable("Pacijent");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adresa = "Breza",
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 346, DateTimeKind.Utc).AddTicks(3077),
                            DatumRođenja = new DateTime(1998, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImePrezime = "Husein Muftić",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SpolID = 1,
                            Telefon = 62528494
                        },
                        new
                        {
                            Id = 2,
                            Adresa = "Sarajevo",
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 346, DateTimeKind.Utc).AddTicks(6307),
                            DatumRođenja = new DateTime(1995, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImePrezime = "Eldin Velic",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SpolID = 1,
                            Telefon = 62222494
                        },
                        new
                        {
                            Id = 3,
                            Adresa = "Sarajevo",
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 346, DateTimeKind.Utc).AddTicks(6367),
                            DatumRođenja = new DateTime(1995, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImePrezime = "Elma Avdukic",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SpolID = 2,
                            Telefon = 62222224
                        });
                });

            modelBuilder.Entity("Klinika.DAL.Models.Prijem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumVrijeme")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HitniPrijem")
                        .HasColumnType("bit");

                    b.Property<int>("LjekarID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PacijentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LjekarID");

                    b.HasIndex("PacijentID");

                    b.ToTable("Prijem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(6977),
                            CreatedBy = "hmuftic",
                            DatumVrijeme = new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(6983),
                            HitniPrijem = false,
                            LjekarID = 3,
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PacijentID = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8373),
                            CreatedBy = "hmuftic",
                            DatumVrijeme = new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8377),
                            HitniPrijem = false,
                            LjekarID = 1,
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PacijentID = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8407),
                            CreatedBy = "hmuftic",
                            DatumVrijeme = new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8408),
                            HitniPrijem = false,
                            LjekarID = 1,
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PacijentID = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8410),
                            CreatedBy = "hmuftic",
                            DatumVrijeme = new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(8411),
                            HitniPrijem = false,
                            LjekarID = 2,
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PacijentID = 2
                        });
                });

            modelBuilder.Entity("Klinika.DAL.Models.Spol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spol");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 348, DateTimeKind.Utc).AddTicks(4266),
                            CreatedBy = "hmuftic",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Naziv = "Musko"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 348, DateTimeKind.Utc).AddTicks(4773),
                            CreatedBy = "hmuftic",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Naziv = "Zensko"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 348, DateTimeKind.Utc).AddTicks(4784),
                            CreatedBy = "hmuftic",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Naziv = "Nepoznato"
                        });
                });

            modelBuilder.Entity("Klinika.DAL.Models.Titula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Titula");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(1939),
                            CreatedBy = "hmuftic",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Naziv = "Specijalista"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(1985),
                            CreatedBy = "hmuftic",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Naziv = "Specijalizant"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 1, 25, 19, 59, 11, 354, DateTimeKind.Utc).AddTicks(1987),
                            CreatedBy = "hmuftic",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Naziv = "Med Sestra"
                        });
                });

            modelBuilder.Entity("Klinika.DAL.Models.Ljekar", b =>
                {
                    b.HasOne("Klinika.DAL.Models.Titula", "Titula")
                        .WithMany("Ljekari")
                        .HasForeignKey("TitulaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Titula");
                });

            modelBuilder.Entity("Klinika.DAL.Models.Nalaz", b =>
                {
                    b.HasOne("Klinika.DAL.Models.Prijem", "Prijem")
                        .WithMany("Nalazi")
                        .HasForeignKey("PrijemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prijem");
                });

            modelBuilder.Entity("Klinika.DAL.Models.Pacijent", b =>
                {
                    b.HasOne("Klinika.DAL.Models.Spol", "Spol")
                        .WithMany("Pacijenti")
                        .HasForeignKey("SpolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Spol");
                });

            modelBuilder.Entity("Klinika.DAL.Models.Prijem", b =>
                {
                    b.HasOne("Klinika.DAL.Models.Ljekar", "Ljekar")
                        .WithMany("Prijemi")
                        .HasForeignKey("LjekarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Klinika.DAL.Models.Pacijent", "Pacijent")
                        .WithMany("Prijemi")
                        .HasForeignKey("PacijentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ljekar");

                    b.Navigation("Pacijent");
                });

            modelBuilder.Entity("Klinika.DAL.Models.Ljekar", b =>
                {
                    b.Navigation("Prijemi");
                });

            modelBuilder.Entity("Klinika.DAL.Models.Pacijent", b =>
                {
                    b.Navigation("Prijemi");
                });

            modelBuilder.Entity("Klinika.DAL.Models.Prijem", b =>
                {
                    b.Navigation("Nalazi");
                });

            modelBuilder.Entity("Klinika.DAL.Models.Spol", b =>
                {
                    b.Navigation("Pacijenti");
                });

            modelBuilder.Entity("Klinika.DAL.Models.Titula", b =>
                {
                    b.Navigation("Ljekari");
                });
#pragma warning restore 612, 618
        }
    }
}
