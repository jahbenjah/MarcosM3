using Microsoft.EntityFrameworkCore.Migrations;

namespace MarcosM3.Infrastructure.Migrations
{
    public partial class SeRenombranTablaUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserioRoles_Roles_RoleId",
                table: "UserioRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserioRoles_Usuario_UserId",
                table: "UserioRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserioRoles",
                table: "UserioRoles");

            migrationBuilder.RenameTable(
                name: "UserioRoles",
                newName: "UsuarioRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UserioRoles_RoleId",
                table: "UsuarioRoles",
                newName: "IX_UsuarioRoles_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioRoles",
                table: "UsuarioRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRoles_Roles_RoleId",
                table: "UsuarioRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRoles_Usuario_UserId",
                table: "UsuarioRoles",
                column: "UserId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRoles_Roles_RoleId",
                table: "UsuarioRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRoles_Usuario_UserId",
                table: "UsuarioRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioRoles",
                table: "UsuarioRoles");

            migrationBuilder.RenameTable(
                name: "UsuarioRoles",
                newName: "UserioRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioRoles_RoleId",
                table: "UserioRoles",
                newName: "IX_UserioRoles_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserioRoles",
                table: "UserioRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserioRoles_Roles_RoleId",
                table: "UserioRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserioRoles_Usuario_UserId",
                table: "UserioRoles",
                column: "UserId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
