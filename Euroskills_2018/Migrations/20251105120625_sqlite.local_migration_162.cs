using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Euroskills_2018.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_162 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orszag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Orszagnev = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orszag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Szakma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Szakmanev = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szakma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Versenyzo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nev = table.Column<string>(type: "TEXT", nullable: false),
                    SzakmaId = table.Column<string>(type: "TEXT", nullable: false),
                    OrszagId = table.Column<string>(type: "TEXT", nullable: false),
                    pont = table.Column<int>(type: "INTEGER", nullable: false),
                    OrszagId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    SzakmaId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versenyzo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Versenyzo_Orszag_OrszagId1",
                        column: x => x.OrszagId1,
                        principalTable: "Orszag",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Versenyzo_Szakma_SzakmaId1",
                        column: x => x.SzakmaId1,
                        principalTable: "Szakma",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Versenyzo_OrszagId1",
                table: "Versenyzo",
                column: "OrszagId1");

            migrationBuilder.CreateIndex(
                name: "IX_Versenyzo_SzakmaId1",
                table: "Versenyzo",
                column: "SzakmaId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Versenyzo");

            migrationBuilder.DropTable(
                name: "Orszag");

            migrationBuilder.DropTable(
                name: "Szakma");
        }
    }
}
