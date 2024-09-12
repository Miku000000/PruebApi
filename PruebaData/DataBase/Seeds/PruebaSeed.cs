using Microsoft.EntityFrameworkCore;
using PruebaData.DataBase.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PruebaData.DataBase.Seeds
{
    internal static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().HasData(
                new Persona
                {
                    id = 1,
                    nombres = "Juan",
                    apellidoPaterno = "Pérez",
                    apellidoMaterno = "García",
                    correo = "juan.perez@example.com",
                    telefonoMovil = "987654321",
                    dni = "12345678"
                },
                new Persona
                {
                    id = 2,
                    nombres = "María",
                    apellidoPaterno = "López",
                    apellidoMaterno = "Martínez",
                    correo = "maria.lopez@example.com",
                    telefonoMovil = "876543210",
                    dni = "87654321"
                }
            );

            modelBuilder.Entity<Pedido>().HasData(
                new Pedido
                {
                    IdPedido = 1,
                    Producto = "Laptop",
                    Cantidad = 1,
                    id_Persona= 1,
                },
                new Pedido
                {
                    IdPedido = 2, 
                    Producto = "Teléfono",
                    Cantidad = 2,
                    id_Persona = 2,
                },
                new Pedido
                {
                    IdPedido = 3,
                    Producto = "Tablet",
                    Cantidad = 1,
                    id_Persona = 1,
                }
            );


        }
    }
}
