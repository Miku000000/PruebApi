using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prueba.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    apellidoPaterno = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    apellidoMaterno = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    correo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    telefonoMovil = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    dni = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Producto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    id_Pedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_Pedidos_id_Pedido",
                        column: x => x.id_Pedido,
                        principalTable: "Pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pedidos",
                columns: new[] { "id", "apellidoMaterno", "apellidoPaterno", "correo", "dni", "nombres", "telefonoMovil" },
                values: new object[,]
                {
                    { 1, "García", "Pérez", "juan.perez@example.com", "12345678", "Juan", "987654321" },
                    { 2, "Martínez", "López", "maria.lopez@example.com", "87654321", "María", "876543210" }
                });

            migrationBuilder.InsertData(
                table: "Pedidos",
                columns: new[] { "IdPedido", "Cantidad", "Producto", "id_Pedido" },
                values: new object[,]
                {
                    { 1, 1, "Laptop", 1 },
                    { 2, 2, "Teléfono", 2 },
                    { 3, 1, "Tablet", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_id_Pedido",
                table: "Pedidos",
                column: "id_Pedido");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
