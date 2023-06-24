using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GHNY.ADC.Migrations
{
    /// <inheritdoc />
    public partial class addfarmers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADCFarmers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, comment: "主键，Guid", collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "姓名")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "电话")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sex = table.Column<int>(type: "int", nullable: true, comment: "性别"),
                    Nation = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "民族")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProvinceId = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: true, comment: "省")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CityId = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: true, comment: "市")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DistrictId = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: true, comment: "区(县)")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TownId = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: true, comment: "镇(乡)")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VillageId = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: true, comment: "村(社区)")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true, comment: "地址")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCard = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: true, comment: "身份证号")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCardStartDate = table.Column<DateTime>(type: "datetime(6)", nullable: true, comment: "身份证开始有效期"),
                    IdCardEndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true, comment: "身份证结束有效期"),
                    BankName = table.Column<string>(type: "longtext", nullable: true, comment: "开户银行")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BankAccount = table.Column<string>(type: "longtext", nullable: true, comment: "银行账号")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountName = table.Column<string>(type: "longtext", nullable: true, comment: "账号姓名")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false, comment: ""),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true, comment: ""),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADCFarmers", x => x.Id);
                },
                comment: "农场主信息")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADCFarmers");
        }
    }
}
