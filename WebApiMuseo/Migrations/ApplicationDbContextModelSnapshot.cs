﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiMuseo;

#nullable disable

namespace WebApiMuseo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ObraSala", b =>
                {
                    b.Property<int>("ObrasId")
                        .HasColumnType("int");

                    b.Property<int>("Salasid")
                        .HasColumnType("int");

                    b.HasKey("ObrasId", "Salasid");

                    b.HasIndex("Salasid");

                    b.ToTable("ObraSala");
                });

            modelBuilder.Entity("WebApiMuseo.Entidades.Exposicion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exposiciones");
                });

            modelBuilder.Entity("WebApiMuseo.Entidades.Obra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("exposicionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("obraCineId")
                        .HasColumnType("int");

                    b.Property<int?>("obraPinturaId")
                        .HasColumnType("int");

                    b.Property<int>("tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("exposicionId");

                    b.HasIndex("obraCineId");

                    b.HasIndex("obraPinturaId");

                    b.ToTable("Obras");
                });

            modelBuilder.Entity("WebApiMuseo.Entidades.ObraCine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("directorId")
                        .HasColumnType("int");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<int?>("escritorId")
                        .HasColumnType("int");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("directorId");

                    b.HasIndex("escritorId");

                    b.ToTable("ObrasCine");
                });

            modelBuilder.Entity("WebApiMuseo.Entidades.ObraPintura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("PintorId")
                        .HasColumnType("int");

                    b.Property<int>("tecnica")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PintorId");

                    b.ToTable("ObrasPintura");
                });

            modelBuilder.Entity("WebApiMuseo.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("es_persona")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("WebApiMuseo.Entidades.Sala", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("ObraSala", b =>
                {
                    b.HasOne("WebApiMuseo.Entidades.Obra", null)
                        .WithMany()
                        .HasForeignKey("ObrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiMuseo.Entidades.Sala", null)
                        .WithMany()
                        .HasForeignKey("Salasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiMuseo.Entidades.Obra", b =>
                {
                    b.HasOne("WebApiMuseo.Entidades.Exposicion", "exposicion")
                        .WithMany("Obras")
                        .HasForeignKey("exposicionId");

                    b.HasOne("WebApiMuseo.Entidades.ObraCine", "obraCine")
                        .WithMany()
                        .HasForeignKey("obraCineId");

                    b.HasOne("WebApiMuseo.Entidades.ObraPintura", "obraPintura")
                        .WithMany()
                        .HasForeignKey("obraPinturaId");

                    b.Navigation("exposicion");

                    b.Navigation("obraCine");

                    b.Navigation("obraPintura");
                });

            modelBuilder.Entity("WebApiMuseo.Entidades.ObraCine", b =>
                {
                    b.HasOne("WebApiMuseo.Entidades.Persona", "director")
                        .WithMany()
                        .HasForeignKey("directorId");

                    b.HasOne("WebApiMuseo.Entidades.Persona", "escritor")
                        .WithMany()
                        .HasForeignKey("escritorId");

                    b.Navigation("director");

                    b.Navigation("escritor");
                });

            modelBuilder.Entity("WebApiMuseo.Entidades.ObraPintura", b =>
                {
                    b.HasOne("WebApiMuseo.Entidades.Persona", "Pintor")
                        .WithMany()
                        .HasForeignKey("PintorId");

                    b.Navigation("Pintor");
                });

            modelBuilder.Entity("WebApiMuseo.Entidades.Exposicion", b =>
                {
                    b.Navigation("Obras");
                });
#pragma warning restore 612, 618
        }
    }
}
