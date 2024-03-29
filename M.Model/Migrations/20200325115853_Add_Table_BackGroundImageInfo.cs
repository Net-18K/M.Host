﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace M.Model.Migrations
{
    public partial class Add_Table_BackGroundImageInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BackGroundImageInfo",
                columns: table => new
                {
                    BGId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BGUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackGroundImageInfo", x => x.BGId);
                });

            migrationBuilder.InsertData(
                table: "BackGroundImageInfo",
                columns: new[] { "BGId", "BGUrl" },
                values: new object[,]
                {
                    { 1, "http://fanghua.host/accsets/images/background/bg1" },
                    { 74, "http://fanghua.host/accsets/images/background/bg74" },
                    { 73, "http://fanghua.host/accsets/images/background/bg73" },
                    { 72, "http://fanghua.host/accsets/images/background/bg72" },
                    { 71, "http://fanghua.host/accsets/images/background/bg71" },
                    { 70, "http://fanghua.host/accsets/images/background/bg70" },
                    { 69, "http://fanghua.host/accsets/images/background/bg69" },
                    { 68, "http://fanghua.host/accsets/images/background/bg68" },
                    { 67, "http://fanghua.host/accsets/images/background/bg67" },
                    { 66, "http://fanghua.host/accsets/images/background/bg66" },
                    { 65, "http://fanghua.host/accsets/images/background/bg65" },
                    { 64, "http://fanghua.host/accsets/images/background/bg64" },
                    { 63, "http://fanghua.host/accsets/images/background/bg63" },
                    { 62, "http://fanghua.host/accsets/images/background/bg62" },
                    { 61, "http://fanghua.host/accsets/images/background/bg61" },
                    { 60, "http://fanghua.host/accsets/images/background/bg60" },
                    { 59, "http://fanghua.host/accsets/images/background/bg59" },
                    { 58, "http://fanghua.host/accsets/images/background/bg58" },
                    { 57, "http://fanghua.host/accsets/images/background/bg57" },
                    { 56, "http://fanghua.host/accsets/images/background/bg56" },
                    { 55, "http://fanghua.host/accsets/images/background/bg55" },
                    { 53, "http://fanghua.host/accsets/images/background/bg53" },
                    { 75, "http://fanghua.host/accsets/images/background/bg75" },
                    { 76, "http://fanghua.host/accsets/images/background/bg76" },
                    { 77, "http://fanghua.host/accsets/images/background/bg77" },
                    { 78, "http://fanghua.host/accsets/images/background/bg78" },
                    { 100, "http://fanghua.host/accsets/images/background/bg100" },
                    { 99, "http://fanghua.host/accsets/images/background/bg99" },
                    { 98, "http://fanghua.host/accsets/images/background/bg98" },
                    { 97, "http://fanghua.host/accsets/images/background/bg97" },
                    { 96, "http://fanghua.host/accsets/images/background/bg96" },
                    { 95, "http://fanghua.host/accsets/images/background/bg95" },
                    { 94, "http://fanghua.host/accsets/images/background/bg94" },
                    { 93, "http://fanghua.host/accsets/images/background/bg93" },
                    { 92, "http://fanghua.host/accsets/images/background/bg92" },
                    { 91, "http://fanghua.host/accsets/images/background/bg91" },
                    { 52, "http://fanghua.host/accsets/images/background/bg52" },
                    { 90, "http://fanghua.host/accsets/images/background/bg90" },
                    { 88, "http://fanghua.host/accsets/images/background/bg88" },
                    { 87, "http://fanghua.host/accsets/images/background/bg87" },
                    { 86, "http://fanghua.host/accsets/images/background/bg86" },
                    { 85, "http://fanghua.host/accsets/images/background/bg85" },
                    { 84, "http://fanghua.host/accsets/images/background/bg84" },
                    { 83, "http://fanghua.host/accsets/images/background/bg83" },
                    { 82, "http://fanghua.host/accsets/images/background/bg82" },
                    { 81, "http://fanghua.host/accsets/images/background/bg81" },
                    { 80, "http://fanghua.host/accsets/images/background/bg80" },
                    { 79, "http://fanghua.host/accsets/images/background/bg79" },
                    { 89, "http://fanghua.host/accsets/images/background/bg89" },
                    { 51, "http://fanghua.host/accsets/images/background/bg51" },
                    { 54, "http://fanghua.host/accsets/images/background/bg54" },
                    { 49, "http://fanghua.host/accsets/images/background/bg49" },
                    { 23, "http://fanghua.host/accsets/images/background/bg23" },
                    { 50, "http://fanghua.host/accsets/images/background/bg50" },
                    { 21, "http://fanghua.host/accsets/images/background/bg21" },
                    { 20, "http://fanghua.host/accsets/images/background/bg20" },
                    { 19, "http://fanghua.host/accsets/images/background/bg19" },
                    { 18, "http://fanghua.host/accsets/images/background/bg18" },
                    { 17, "http://fanghua.host/accsets/images/background/bg17" },
                    { 16, "http://fanghua.host/accsets/images/background/bg16" },
                    { 15, "http://fanghua.host/accsets/images/background/bg15" },
                    { 14, "http://fanghua.host/accsets/images/background/bg14" },
                    { 24, "http://fanghua.host/accsets/images/background/bg24" },
                    { 13, "http://fanghua.host/accsets/images/background/bg13" },
                    { 11, "http://fanghua.host/accsets/images/background/bg11" },
                    { 10, "http://fanghua.host/accsets/images/background/bg10" },
                    { 9, "http://fanghua.host/accsets/images/background/bg9" },
                    { 8, "http://fanghua.host/accsets/images/background/bg8" },
                    { 7, "http://fanghua.host/accsets/images/background/bg7" },
                    { 6, "http://fanghua.host/accsets/images/background/bg6" },
                    { 5, "http://fanghua.host/accsets/images/background/bg5" },
                    { 4, "http://fanghua.host/accsets/images/background/bg4" },
                    { 3, "http://fanghua.host/accsets/images/background/bg3" },
                    { 2, "http://fanghua.host/accsets/images/background/bg2" },
                    { 12, "http://fanghua.host/accsets/images/background/bg12" },
                    { 25, "http://fanghua.host/accsets/images/background/bg25" },
                    { 22, "http://fanghua.host/accsets/images/background/bg22" },
                    { 27, "http://fanghua.host/accsets/images/background/bg27" },
                    { 48, "http://fanghua.host/accsets/images/background/bg48" },
                    { 47, "http://fanghua.host/accsets/images/background/bg47" },
                    { 46, "http://fanghua.host/accsets/images/background/bg46" },
                    { 45, "http://fanghua.host/accsets/images/background/bg45" },
                    { 44, "http://fanghua.host/accsets/images/background/bg44" },
                    { 43, "http://fanghua.host/accsets/images/background/bg43" },
                    { 26, "http://fanghua.host/accsets/images/background/bg26" },
                    { 41, "http://fanghua.host/accsets/images/background/bg41" },
                    { 40, "http://fanghua.host/accsets/images/background/bg40" },
                    { 39, "http://fanghua.host/accsets/images/background/bg39" },
                    { 42, "http://fanghua.host/accsets/images/background/bg42" },
                    { 37, "http://fanghua.host/accsets/images/background/bg37" },
                    { 28, "http://fanghua.host/accsets/images/background/bg28" },
                    { 38, "http://fanghua.host/accsets/images/background/bg38" },
                    { 30, "http://fanghua.host/accsets/images/background/bg30" },
                    { 31, "http://fanghua.host/accsets/images/background/bg31" },
                    { 29, "http://fanghua.host/accsets/images/background/bg29" },
                    { 33, "http://fanghua.host/accsets/images/background/bg33" },
                    { 34, "http://fanghua.host/accsets/images/background/bg34" },
                    { 35, "http://fanghua.host/accsets/images/background/bg35" },
                    { 36, "http://fanghua.host/accsets/images/background/bg36" },
                    { 32, "http://fanghua.host/accsets/images/background/bg32" }
                });

            migrationBuilder.UpdateData(
                table: "DevLoveInfo",
                keyColumn: "DLId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 312, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 313, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(774));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackGroundImageInfo");

            migrationBuilder.UpdateData(
                table: "DevLoveInfo",
                keyColumn: "DLId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 8, 6, 514, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 8, 6, 515, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 8, 6, 515, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 8, 6, 515, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 8, 6, 515, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 8, 6, 515, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 8, 6, 515, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 8, 6, 515, DateTimeKind.Local).AddTicks(5004));
        }
    }
}