using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalepSistemi.Migrations
{
    public partial class migTalepSistemi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminlik = table.Column<bool>(type: "bit", nullable: false),
                    Konum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fotograf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Talepler",
                columns: table => new
                {
                    TalepID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TalepGonderen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TalepDepartman = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TalepKonu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TalepAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TalepDurum = table.Column<bool>(type: "bit", nullable: false),
                    TalepTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Talepler");
        }
    }
}
