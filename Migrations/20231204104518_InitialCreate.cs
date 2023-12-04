using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDotnet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "barang",
                columns: table => new
                {
                    barang_id = table.Column<Guid>(type: "uuid", nullable: false),
                    kode_negara = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    ur_barang = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_barang", x => x.barang_id);
                });

            migrationBuilder.CreateTable(
                name: "negara",
                columns: table => new
                {
                    negara_id = table.Column<Guid>(type: "uuid", nullable: false),
                    kode_negara = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    ur_negara = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_negara", x => x.negara_id);
                });

            migrationBuilder.CreateTable(
                name: "pelabuhan",
                columns: table => new
                {
                    pelabuhan_id = table.Column<Guid>(type: "uuid", nullable: false),
                    kode_negara = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    ur_pelabuhan = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pelabuhan", x => x.pelabuhan_id);
                });

            migrationBuilder.CreateTable(
                name: "harga",
                columns: table => new
                {
                    harga_id = table.Column<Guid>(type: "uuid", nullable: false),
                    barang_id = table.Column<Guid>(type: "uuid", nullable: false),
                    jumlah = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_harga", x => x.harga_id);
                    table.ForeignKey(
                        name: "FK_harga_barang_barang_id",
                        column: x => x.barang_id,
                        principalTable: "barang",
                        principalColumn: "barang_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tarif",
                columns: table => new
                {
                    tarif_id = table.Column<Guid>(type: "uuid", nullable: false),
                    barang_id = table.Column<Guid>(type: "uuid", nullable: false),
                    persentase = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tarif", x => x.tarif_id);
                    table.ForeignKey(
                        name: "FK_tarif_barang_barang_id",
                        column: x => x.barang_id,
                        principalTable: "barang",
                        principalColumn: "barang_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_harga_barang_id",
                table: "harga",
                column: "barang_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tarif_barang_id",
                table: "tarif",
                column: "barang_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "harga");

            migrationBuilder.DropTable(
                name: "negara");

            migrationBuilder.DropTable(
                name: "pelabuhan");

            migrationBuilder.DropTable(
                name: "tarif");

            migrationBuilder.DropTable(
                name: "barang");
        }
    }
}
