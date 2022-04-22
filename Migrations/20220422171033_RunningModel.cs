using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group8_Hobbies.Migrations
{
    public partial class RunningModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    RunningId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Distance = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.RunningId);
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "RunningId", "Date", "Distance", "Name", "Website" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26.199999999999999, "Cincinnati Flying Pig", "https://flyingpigmarathon.com" },
                    { 2, new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1000000000000001, "Cleveland Turkey Trot", "https://www.turkeytrotcleveland.com" },
                    { 3, new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 26.199999999999999, "Boston Marathon", "https://www.baa.org" },
                    { 4, new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.2000000000000002, "Bolder Boulder 10k", "https://www.bolderboulder.com" },
                    { 5, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 26.199999999999999, "Chicago Marathon", "https://www.chicagomarathon.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
