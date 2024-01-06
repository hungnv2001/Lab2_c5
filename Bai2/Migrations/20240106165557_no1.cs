using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bai2.Migrations
{
    public partial class no1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "char(9)", maxLength: 9, nullable: false),
                    Honv = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    TenLot = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    TenNV = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    DChi = table.Column<string>(type: "nchar(30)", maxLength: 30, nullable: true),
                    Phai = table.Column<string>(type: "nchar(3)", maxLength: 3, nullable: true),
                    Luong = table.Column<double>(type: "float", nullable: true),
                    MaNQL = table.Column<string>(type: "char(9)", maxLength: 9, nullable: true),
                    PHG = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "ThanNhan",
                columns: table => new
                {
                    Ma_NV = table.Column<string>(type: "char(9)", maxLength: 9, nullable: false),
                    TenTN = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Phai = table.Column<string>(type: "char(3)", maxLength: 3, nullable: true),
                    NgSinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    QuanHe = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanNhan", x => new { x.Ma_NV, x.TenTN });
                    table.ForeignKey(
                        name: "FK_ThanNhan_NhanVien_Ma_NV",
                        column: x => x.Ma_NV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThanNhan");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
