﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaData.DataBase;

#nullable disable

namespace Prueba.Migrations
{
    [DbContext(typeof(MiDbContext))]
    partial class MiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PruebaData.DataBase.Tables.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPedido"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Producto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("id_Pedido")
                        .HasColumnType("int");

                    b.HasKey("IdPedido");

                    b.HasIndex("id_Pedido");

                    b.ToTable("Pedidos");

                    b.HasData(
                        new
                        {
                            IdPedido = 1,
                            Cantidad = 1,
                            Producto = "Laptop",
                            id_Pedido = 1
                        },
                        new
                        {
                            IdPedido = 2,
                            Cantidad = 2,
                            Producto = "Teléfono",
                            id_Pedido = 2
                        },
                        new
                        {
                            IdPedido = 3,
                            Cantidad = 1,
                            Producto = "Tablet",
                            id_Pedido = 1
                        });
                });

            modelBuilder.Entity("PruebaData.DataBase.Tables.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("apellidoMaterno")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("apellidoPaterno")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("dni")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("telefonoMovil")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("id");

                    b.ToTable("Pedidos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            apellidoMaterno = "García",
                            apellidoPaterno = "Pérez",
                            correo = "juan.perez@example.com",
                            dni = "12345678",
                            nombres = "Juan",
                            telefonoMovil = "987654321"
                        },
                        new
                        {
                            id = 2,
                            apellidoMaterno = "Martínez",
                            apellidoPaterno = "López",
                            correo = "maria.lopez@example.com",
                            dni = "87654321",
                            nombres = "María",
                            telefonoMovil = "876543210"
                        });
                });

            modelBuilder.Entity("PruebaData.DataBase.Tables.Pedido", b =>
                {
                    b.HasOne("PruebaData.DataBase.Tables.Pedido", null)
                        .WithMany()
                        .HasForeignKey("id_Pedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
