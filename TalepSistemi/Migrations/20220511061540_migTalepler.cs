using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalepSistemi.Migrations
{
    public partial class migTalepler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Talepler",
                columns: table => new
                {
                    TalepID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TalepGonderen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TalepDepartman = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TalepKonu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TalepAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TalepDurum = table.Column<bool>(type: "bit", nullable: true),
                    TalepTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talepler", x => x.TalepID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Talepler");
        }
    }
}
