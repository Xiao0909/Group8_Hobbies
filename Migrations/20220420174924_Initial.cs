using Microsoft.EntityFrameworkCore.Migrations;

namespace Group8_Hobbies.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publishes",
                columns: table => new
                {
                    PublisherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishes", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Animations",
                columns: table => new
                {
                    AnimeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PublishYear = table.Column<int>(nullable: false),
                    WatchingYear = table.Column<int>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    PublisherId = table.Column<int>(nullable: false),
                    PublisherId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animations", x => x.AnimeId);
                    table.ForeignKey(
                        name: "FK_Animations_Publishes_PublisherId1",
                        column: x => x.PublisherId1,
                        principalTable: "Publishes",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Animations",
                columns: new[] { "AnimeId", "Name", "PublishYear", "PublisherId", "PublisherId1", "Rate", "WatchingYear" },
                values: new object[,]
                {
                    { 1, "Demon Slayer", 2019, 1, null, 4, 2020 },
                    { 2, "My NeighborTotoro", 1988, 2, null, 5, 2007 },
                    { 3, "White Cat Legend", 2020, 3, null, 4, 2020 }
                });

            migrationBuilder.InsertData(
                table: "Publishes",
                columns: new[] { "PublisherId", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Japan", "UFOTable" },
                    { 2, "Japan", "Ghibli" },
                    { 3, "China", "Nice Boat Animation Studio" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animations_PublisherId1",
                table: "Animations",
                column: "PublisherId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animations");

            migrationBuilder.DropTable(
                name: "Publishes");
        }
    }
}
