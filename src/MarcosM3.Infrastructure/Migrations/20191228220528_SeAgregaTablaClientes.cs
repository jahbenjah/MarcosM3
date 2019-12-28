using Microsoft.EntityFrameworkCore.Migrations;

namespace MarcosM3.Infrastructure.Migrations
{
    public partial class SeAgregaTablaClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    RazonSocial = table.Column<string>(maxLength: 200, nullable: true),
                    Direccion = table.Column<string>(maxLength: 200, nullable: true),
                    RFC = table.Column<string>(maxLength: 20, nullable: true),
                    Telefono = table.Column<string>(maxLength: 50, nullable: true),
                    Correo = table.Column<string>(maxLength: 100, nullable: true),
                    RequiereFactura = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
