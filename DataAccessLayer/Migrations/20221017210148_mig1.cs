using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_BOLUM",
                columns: table => new
                {
                    BOLUM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BOLUM", x => x.BOLUM_ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_DERS",
                columns: table => new
                {
                    DERS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DERS", x => x.DERS_ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_SCHOOL_DURUMLARI",
                columns: table => new
                {
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LISANS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OKUL_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OKUL_MAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OKUL_TELOFON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OKUL_FAX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SORUMLU_YETKILI1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SORUMLU_YETKILI_NUMARA1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SORUMLU_YETKILI2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SORUMLU_YETKILI_NUMARA2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASLAMA_TARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BITIS_TARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLENEME_TARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KURUM_KODU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DURUM = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_SCHOOL_DURUMLARI", x => x.SCHOOL_ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_DERSLER",
                columns: table => new
                {
                    DERSLER_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DERSLER", x => x.DERSLER_ID);
                    table.ForeignKey(
                        name: "FK_TBL_DERSLER_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_IDARI_PERSONEL",
                columns: table => new
                {
                    IDARI_PERSONEL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOYADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UNVAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TELEFON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIFRE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_IDARI_PERSONEL", x => x.IDARI_PERSONEL_ID);
                    table.ForeignKey(
                        name: "FK_TBL_IDARI_PERSONEL_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_KURUM",
                columns: table => new
                {
                    KURUM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KURUM_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURUM_LISANS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURUM_LOGO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_DONEM = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_KURUM", x => x.KURUM_ID);
                    table.ForeignKey(
                        name: "FK_TBL_KURUM_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_LOG",
                columns: table => new
                {
                    TBL_LOG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GIRIS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CIKIS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_LOG", x => x.TBL_LOG_ID);
                    table.ForeignKey(
                        name: "FK_TBL_LOG_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_MESAJ_HAREKETLERI",
                columns: table => new
                {
                    MESAJ_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KULLANICI_TURU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KULLANICI_ID = table.Column<int>(type: "int", nullable: false),
                    MESAJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SAAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true),
                    USER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_MESAJ_HAREKETLERI", x => x.MESAJ_ID);
                    table.ForeignKey(
                        name: "FK_TBL_MESAJ_HAREKETLERI_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_MESAJ_PATH",
                columns: table => new
                {
                    MESAJ_PATH_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRMA_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    API = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    API_KEY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SENDER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHARSET = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_MESAJ_PATH", x => x.MESAJ_PATH_ID);
                    table.ForeignKey(
                        name: "FK_TBL_MESAJ_PATH_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_SINIF",
                columns: table => new
                {
                    SINIF_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_SINIF", x => x.SINIF_ID);
                    table.ForeignKey(
                        name: "FK_TBL_SINIF_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_SUBE",
                columns: table => new
                {
                    SUBE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_SUBE", x => x.SUBE_ID);
                    table.ForeignKey(
                        name: "FK_TBL_SUBE_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_TRY_CATCH",
                columns: table => new
                {
                    TRY_CATCH_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ERROR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISLEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DURUM = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TRY_CATCH", x => x.TRY_CATCH_ID);
                    table.ForeignKey(
                        name: "FK_TBL_TRY_CATCH_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_DONEM",
                columns: table => new
                {
                    DONEM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: false),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TBL_IDARI_PERSONELIDARI_PERSONEL_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DONEM", x => x.DONEM_ID);
                    table.ForeignKey(
                        name: "FK_TBL_DONEM_TBL_IDARI_PERSONEL_TBL_IDARI_PERSONELIDARI_PERSONEL_ID",
                        column: x => x.TBL_IDARI_PERSONELIDARI_PERSONEL_ID,
                        principalTable: "TBL_IDARI_PERSONEL",
                        principalColumn: "IDARI_PERSONEL_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_DERS_PROGRAMI",
                columns: table => new
                {
                    DERS_PROGRAM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true),
                    OGRETMENIDARI_PERSONEL_ID = table.Column<int>(type: "int", nullable: true),
                    DONEM_ID = table.Column<int>(type: "int", nullable: true),
                    DERS_ID = table.Column<int>(type: "int", nullable: true),
                    SINIF_ID = table.Column<int>(type: "int", nullable: true),
                    SUBE_ID = table.Column<int>(type: "int", nullable: true),
                    GUN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DERS_PROGRAMI", x => x.DERS_PROGRAM_ID);
                    table.ForeignKey(
                        name: "FK_TBL_DERS_PROGRAMI_TBL_DERS_DERS_ID",
                        column: x => x.DERS_ID,
                        principalTable: "TBL_DERS",
                        principalColumn: "DERS_ID");
                    table.ForeignKey(
                        name: "FK_TBL_DERS_PROGRAMI_TBL_DONEM_DONEM_ID",
                        column: x => x.DONEM_ID,
                        principalTable: "TBL_DONEM",
                        principalColumn: "DONEM_ID");
                    table.ForeignKey(
                        name: "FK_TBL_DERS_PROGRAMI_TBL_IDARI_PERSONEL_OGRETMENIDARI_PERSONEL_ID",
                        column: x => x.OGRETMENIDARI_PERSONEL_ID,
                        principalTable: "TBL_IDARI_PERSONEL",
                        principalColumn: "IDARI_PERSONEL_ID");
                    table.ForeignKey(
                        name: "FK_TBL_DERS_PROGRAMI_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                    table.ForeignKey(
                        name: "FK_TBL_DERS_PROGRAMI_TBL_SINIF_SINIF_ID",
                        column: x => x.SINIF_ID,
                        principalTable: "TBL_SINIF",
                        principalColumn: "SINIF_ID");
                    table.ForeignKey(
                        name: "FK_TBL_DERS_PROGRAMI_TBL_SUBE_SUBE_ID",
                        column: x => x.SUBE_ID,
                        principalTable: "TBL_SUBE",
                        principalColumn: "SUBE_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_OGRENCI",
                columns: table => new
                {
                    OGRENCI_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VATADANDAS_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OKUL_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOYADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SINIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUBE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TELEFON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOLUM_ID = table.Column<int>(type: "int", nullable: true),
                    DONEM_ID = table.Column<int>(type: "int", nullable: true),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_OGRENCI", x => x.OGRENCI_ID);
                    table.ForeignKey(
                        name: "FK_TBL_OGRENCI_TBL_BOLUM_BOLUM_ID",
                        column: x => x.BOLUM_ID,
                        principalTable: "TBL_BOLUM",
                        principalColumn: "BOLUM_ID");
                    table.ForeignKey(
                        name: "FK_TBL_OGRENCI_TBL_DONEM_DONEM_ID",
                        column: x => x.DONEM_ID,
                        principalTable: "TBL_DONEM",
                        principalColumn: "DONEM_ID");
                    table.ForeignKey(
                        name: "FK_TBL_OGRENCI_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_VELI",
                columns: table => new
                {
                    VELI_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOYADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TELEFON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OGRENCI_ID = table.Column<int>(type: "int", nullable: true),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: false),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_VELI", x => x.VELI_ID);
                    table.ForeignKey(
                        name: "FK_TBL_VELI_TBL_OGRENCI_OGRENCI_ID",
                        column: x => x.OGRENCI_ID,
                        principalTable: "TBL_OGRENCI",
                        principalColumn: "OGRENCI_ID");
                    table.ForeignKey(
                        name: "FK_TBL_VELI_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_YOKLAMA_HAREKETLERI",
                columns: table => new
                {
                    YOKLAMA_HAREKETLERI_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROGRAMDERS_PROGRAM_ID = table.Column<int>(type: "int", nullable: true),
                    OGRENCI_ID = table.Column<int>(type: "int", nullable: true),
                    DONEM_ID = table.Column<int>(type: "int", nullable: true),
                    SCHOOL_ID = table.Column<int>(type: "int", nullable: true),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SAAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MESAJ_DURUM = table.Column<bool>(type: "bit", nullable: false),
                    EOKUL_DURUM = table.Column<bool>(type: "bit", nullable: false),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    OZEL_KOD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_YOKLAMA_HAREKETLERI", x => x.YOKLAMA_HAREKETLERI_ID);
                    table.ForeignKey(
                        name: "FK_TBL_YOKLAMA_HAREKETLERI_TBL_DERS_PROGRAMI_PROGRAMDERS_PROGRAM_ID",
                        column: x => x.PROGRAMDERS_PROGRAM_ID,
                        principalTable: "TBL_DERS_PROGRAMI",
                        principalColumn: "DERS_PROGRAM_ID");
                    table.ForeignKey(
                        name: "FK_TBL_YOKLAMA_HAREKETLERI_TBL_DONEM_DONEM_ID",
                        column: x => x.DONEM_ID,
                        principalTable: "TBL_DONEM",
                        principalColumn: "DONEM_ID");
                    table.ForeignKey(
                        name: "FK_TBL_YOKLAMA_HAREKETLERI_TBL_OGRENCI_OGRENCI_ID",
                        column: x => x.OGRENCI_ID,
                        principalTable: "TBL_OGRENCI",
                        principalColumn: "OGRENCI_ID");
                    table.ForeignKey(
                        name: "FK_TBL_YOKLAMA_HAREKETLERI_TBL_SCHOOL_DURUMLARI_SCHOOL_ID",
                        column: x => x.SCHOOL_ID,
                        principalTable: "TBL_SCHOOL_DURUMLARI",
                        principalColumn: "SCHOOL_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_DERS_PROGRAMI_DERS_ID",
                table: "TBL_DERS_PROGRAMI",
                column: "DERS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_DERS_PROGRAMI_DONEM_ID",
                table: "TBL_DERS_PROGRAMI",
                column: "DONEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_DERS_PROGRAMI_OGRETMENIDARI_PERSONEL_ID",
                table: "TBL_DERS_PROGRAMI",
                column: "OGRETMENIDARI_PERSONEL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_DERS_PROGRAMI_SCHOOL_ID",
                table: "TBL_DERS_PROGRAMI",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_DERS_PROGRAMI_SINIF_ID",
                table: "TBL_DERS_PROGRAMI",
                column: "SINIF_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_DERS_PROGRAMI_SUBE_ID",
                table: "TBL_DERS_PROGRAMI",
                column: "SUBE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_DERSLER_SCHOOL_ID",
                table: "TBL_DERSLER",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_DONEM_TBL_IDARI_PERSONELIDARI_PERSONEL_ID",
                table: "TBL_DONEM",
                column: "TBL_IDARI_PERSONELIDARI_PERSONEL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_IDARI_PERSONEL_SCHOOL_ID",
                table: "TBL_IDARI_PERSONEL",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_KURUM_SCHOOL_ID",
                table: "TBL_KURUM",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_LOG_SCHOOL_ID",
                table: "TBL_LOG",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_MESAJ_HAREKETLERI_SCHOOL_ID",
                table: "TBL_MESAJ_HAREKETLERI",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_MESAJ_PATH_SCHOOL_ID",
                table: "TBL_MESAJ_PATH",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_OGRENCI_BOLUM_ID",
                table: "TBL_OGRENCI",
                column: "BOLUM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_OGRENCI_DONEM_ID",
                table: "TBL_OGRENCI",
                column: "DONEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_OGRENCI_SCHOOL_ID",
                table: "TBL_OGRENCI",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_SINIF_SCHOOL_ID",
                table: "TBL_SINIF",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_SUBE_SCHOOL_ID",
                table: "TBL_SUBE",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_TRY_CATCH_SCHOOL_ID",
                table: "TBL_TRY_CATCH",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_VELI_OGRENCI_ID",
                table: "TBL_VELI",
                column: "OGRENCI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_VELI_SCHOOL_ID",
                table: "TBL_VELI",
                column: "SCHOOL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_YOKLAMA_HAREKETLERI_DONEM_ID",
                table: "TBL_YOKLAMA_HAREKETLERI",
                column: "DONEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_YOKLAMA_HAREKETLERI_OGRENCI_ID",
                table: "TBL_YOKLAMA_HAREKETLERI",
                column: "OGRENCI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_YOKLAMA_HAREKETLERI_PROGRAMDERS_PROGRAM_ID",
                table: "TBL_YOKLAMA_HAREKETLERI",
                column: "PROGRAMDERS_PROGRAM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_YOKLAMA_HAREKETLERI_SCHOOL_ID",
                table: "TBL_YOKLAMA_HAREKETLERI",
                column: "SCHOOL_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_DERSLER");

            migrationBuilder.DropTable(
                name: "TBL_KURUM");

            migrationBuilder.DropTable(
                name: "TBL_LOG");

            migrationBuilder.DropTable(
                name: "TBL_MESAJ_HAREKETLERI");

            migrationBuilder.DropTable(
                name: "TBL_MESAJ_PATH");

            migrationBuilder.DropTable(
                name: "TBL_TRY_CATCH");

            migrationBuilder.DropTable(
                name: "TBL_VELI");

            migrationBuilder.DropTable(
                name: "TBL_YOKLAMA_HAREKETLERI");

            migrationBuilder.DropTable(
                name: "TBL_DERS_PROGRAMI");

            migrationBuilder.DropTable(
                name: "TBL_OGRENCI");

            migrationBuilder.DropTable(
                name: "TBL_DERS");

            migrationBuilder.DropTable(
                name: "TBL_SINIF");

            migrationBuilder.DropTable(
                name: "TBL_SUBE");

            migrationBuilder.DropTable(
                name: "TBL_BOLUM");

            migrationBuilder.DropTable(
                name: "TBL_DONEM");

            migrationBuilder.DropTable(
                name: "TBL_IDARI_PERSONEL");

            migrationBuilder.DropTable(
                name: "TBL_SCHOOL_DURUMLARI");
        }
    }
}
