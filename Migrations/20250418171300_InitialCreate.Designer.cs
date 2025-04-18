﻿// <auto-generated />
using System;
using DiarioMedico.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiarioMedico.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250418171300_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("DiarioMedico.Models.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombredeCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("DiarioMedico.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("DiarioMedico.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Doctores");
                });

            modelBuilder.Entity("DiarioMedico.Models.Cita", b =>
                {
                    b.HasOne("DiarioMedico.Models.Cliente", null)
                        .WithMany("Citas")
                        .HasForeignKey("ClienteId");

                    b.HasOne("DiarioMedico.Models.Doctor", "Doctor")
                        .WithMany("Citas")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DiarioMedico.Models.Cliente", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("DiarioMedico.Models.Doctor", b =>
                {
                    b.Navigation("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}
