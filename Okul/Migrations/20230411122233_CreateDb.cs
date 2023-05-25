using Microsoft.EntityFrameworkCore.Migrations;

namespace Okul.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Derss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DersKredi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    ToplamTecrube = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Derss");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Ogretmens");
        }
    }
}
