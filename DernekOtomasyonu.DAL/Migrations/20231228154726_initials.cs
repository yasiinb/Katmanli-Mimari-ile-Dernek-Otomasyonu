using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DernekOtomasyonu.DAL.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aidats",
                columns: table => new
                {
                    AidatID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    AidatMiktar = table.Column<int>(nullable: false),
                    AidatTarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aidats", x => x.AidatID);
                });

            migrationBuilder.CreateTable(
                name: "Etkinliks",
                columns: table => new
                {
                    EtkinlikID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    EtkinlikAdi = table.Column<string>(nullable: true),
                    EtkinlikAciklamasi = table.Column<string>(nullable: true),
                    EtkinlikTarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etkinliks", x => x.EtkinlikID);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    PersonelAd = table.Column<string>(nullable: true),
                    PersonelSoyad = table.Column<string>(nullable: true),
                    PersonelTelefon = table.Column<string>(nullable: true),
                    PersonelMail = table.Column<string>(nullable: true),
                    PersonelKullaniciAdi = table.Column<string>(nullable: true),
                    PersonelSifre = table.Column<string>(nullable: true),
                    PersonelYetki = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelID);
                });

            migrationBuilder.CreateTable(
                name: "Uyes",
                columns: table => new
                {
                    UyeTC = table.Column<string>(nullable: false),
                    UyeID = table.Column<int>(nullable: false),
                    UyeAdi = table.Column<string>(nullable: true),
                    UyeSoyadi = table.Column<string>(nullable: true),
                    Kangurubu = table.Column<string>(nullable: true),
                    UyeTelefonNo = table.Column<string>(nullable: true),
                    Sehir = table.Column<string>(nullable: true),
                    UyeMail = table.Column<string>(nullable: true),
                    KatilimTarihi = table.Column<DateTime>(nullable: false),
                    KalanAidat = table.Column<int>(nullable: false),
                    AktifDurum = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyes", x => x.UyeTC);
                });

            migrationBuilder.CreateTable(
                name: "Odemelers",
                columns: table => new
                {
                    OdemeID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    AidatID = table.Column<int>(nullable: false),
                    UyeTC = table.Column<string>(nullable: false),
                    Durum = table.Column<bool>(nullable: false),
                   
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odemelers", x => x.OdemeID);
                    table.ForeignKey(
                        name: "FK_Odemelers_Aidats_AidatID",
                        column: x => x.AidatID,
                        principalTable: "Aidats",
                        principalColumn: "AidatID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Odemelers_Uyes_UyeTC",
                        column: x => x.UyeTC,
                        principalTable: "Uyes",
                        principalColumn: "UyeTC",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Odemelers_AidatID",
                table: "Odemelers",
                column: "AidatID");

            migrationBuilder.CreateIndex(
                name: "IX_Odemelers_UyeTC",
                table: "Odemelers",
                column: "UyeTC" );
              
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Etkinliks");

            migrationBuilder.DropTable(
                name: "Odemelers");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Aidats");

            migrationBuilder.DropTable(
                name: "Uyes");
        }
    }
}
