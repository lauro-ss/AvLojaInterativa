using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvLojaInterativa.Migrations
{
    public partial class InicialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fabricante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Categoria_1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Categoria_2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Categoria_3 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IdFabricante = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Preco = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "fk_produto_fabricante",
                        column: x => x.IdFabricante,
                        principalTable: "Fabricante",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "fk_produto_fabricante_ind",
                table: "Produto",
                column: "IdFabricante");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Fabricante");
        }
    }
}
