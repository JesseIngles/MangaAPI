﻿// <auto-generated />
using System;
using CelsonApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CelsonApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("CelsonApi.Models.Tabelas.TbAvaliacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("mangaId")
                        .HasColumnType("TEXT");

                    b.Property<int>("nota")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("userId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("mangaId");

                    b.HasIndex("userId");

                    b.ToTable("Avaliacaos");
                });

            modelBuilder.Entity("CelsonApi.Models.Tabelas.TbManga", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Mangas");
                });

            modelBuilder.Entity("CelsonApi.Models.Tabelas.TbUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CelsonApi.Models.TbCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TbMangaId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TbMangaId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CelsonApi.Models.Tabelas.TbAvaliacao", b =>
                {
                    b.HasOne("CelsonApi.Models.Tabelas.TbManga", "manga")
                        .WithMany("Avaliacaos")
                        .HasForeignKey("mangaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CelsonApi.Models.Tabelas.TbUser", "user")
                        .WithMany("Avaliacaos")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("manga");

                    b.Navigation("user");
                });

            modelBuilder.Entity("CelsonApi.Models.TbCategory", b =>
                {
                    b.HasOne("CelsonApi.Models.Tabelas.TbManga", null)
                        .WithMany("Categories")
                        .HasForeignKey("TbMangaId");
                });

            modelBuilder.Entity("CelsonApi.Models.Tabelas.TbManga", b =>
                {
                    b.Navigation("Avaliacaos");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("CelsonApi.Models.Tabelas.TbUser", b =>
                {
                    b.Navigation("Avaliacaos");
                });
#pragma warning restore 612, 618
        }
    }
}
