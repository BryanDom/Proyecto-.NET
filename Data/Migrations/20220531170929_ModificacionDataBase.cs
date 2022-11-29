using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestauranteMexicano.Data.Migrations
{
    public partial class ModificacionDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Platillo_Categoria_IdCategoria",
                table: "Platillo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platillo",
                table: "Platillo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Platillo",
                newName: "Platillos");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.RenameIndex(
                name: "IX_Platillo_IdCategoria",
                table: "Platillos",
                newName: "IX_Platillos_IdCategoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platillos",
                table: "Platillos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Platillos_Categorias_IdCategoria",
                table: "Platillos",
                column: "IdCategoria",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Platillos_Categorias_IdCategoria",
                table: "Platillos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platillos",
                table: "Platillos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Platillos",
                newName: "Platillo");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.RenameIndex(
                name: "IX_Platillos_IdCategoria",
                table: "Platillo",
                newName: "IX_Platillo_IdCategoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platillo",
                table: "Platillo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Platillo_Categoria_IdCategoria",
                table: "Platillo",
                column: "IdCategoria",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
