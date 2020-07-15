﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pesquisa.Data;

namespace pesquisa.Migrations
{
    [DbContext(typeof(pesquisaContext))]
    [Migration("20200715165940_relacionamento2")]
    partial class relacionamento2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("pesquisa.Models.Pergunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PerguntaCompleta")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PerguntaSimpl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Pergunta");
                });

            modelBuilder.Entity("pesquisa.Models.Resposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PerguntaId")
                        .HasColumnType("int");

                    b.Property<string>("RespostaCompleta")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RespostaSimpl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Resposta");
                });
#pragma warning restore 612, 618
        }
    }
}
