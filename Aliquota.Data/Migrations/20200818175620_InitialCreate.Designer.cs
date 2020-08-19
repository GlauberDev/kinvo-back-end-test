﻿// <auto-generated />
using System;
using Aliquota.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aliquota.Data.Migrations
{
    [DbContext(typeof(AliquotaContext))]
    [Migration("20200818175620_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("Aliquota.Domain.Entities.AplicacaoRF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataAplicacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataResgate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TaxaJurosAnual")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorAplicado")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AplicacoesRF");
                });
#pragma warning restore 612, 618
        }
    }
}
