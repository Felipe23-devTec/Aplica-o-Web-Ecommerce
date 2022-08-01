﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebEcommerce.Data;

namespace WebbAppEcommerce.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20220731141741_mudandoIntegridaderelacionalPedido")]
    partial class mudandoIntegridaderelacionalPedido
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebbAppEcommerce.Entities.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnderecoIdEndereco")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.HasIndex("EnderecoIdEndereco");

                    b.ToTable("tb_Cliente");
                });

            modelBuilder.Entity("WebbAppEcommerce.Entities.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEndereco");

                    b.ToTable("tb_Endereco");
                });

            modelBuilder.Entity("WebbAppEcommerce.Entities.ItemPedido", b =>
                {
                    b.Property<int>("IdItemPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PedidoIdPEdido")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProdutoIdProduto")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("IdItemPedido");

                    b.HasIndex("PedidoIdPEdido");

                    b.HasIndex("ProdutoIdProduto");

                    b.ToTable("tb_ItemPedido");
                });

            modelBuilder.Entity("WebbAppEcommerce.Entities.Pedido", b =>
                {
                    b.Property<int>("IdPEdido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteIdCliente")
                        .HasColumnType("int");

                    b.HasKey("IdPEdido");

                    b.HasIndex("ClienteIdCliente");

                    b.ToTable("tb_Pedido");
                });

            modelBuilder.Entity("WebbAppEcommerce.Entities.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdProduto");

                    b.ToTable("tb_Produto");
                });

            modelBuilder.Entity("WebbAppEcommerce.Entities.Cliente", b =>
                {
                    b.HasOne("WebbAppEcommerce.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoIdEndereco");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("WebbAppEcommerce.Entities.ItemPedido", b =>
                {
                    b.HasOne("WebbAppEcommerce.Entities.Pedido", "Pedido")
                        .WithMany("Itens")
                        .HasForeignKey("PedidoIdPEdido");

                    b.HasOne("WebbAppEcommerce.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoIdProduto");

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("WebbAppEcommerce.Entities.Pedido", b =>
                {
                    b.HasOne("WebbAppEcommerce.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteIdCliente");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("WebbAppEcommerce.Entities.Pedido", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
