using Microsoft.EntityFrameworkCore.Migrations;

namespace Group8_Hobbies.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animations",
                columns: table => new
                {
                    AnimeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    PublishYear = table.Column<int>(nullable: false),
                    WatchingYear = table.Column<int>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    PublisherName = table.Column<string>(nullable: false),
                    PublisherCountry = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animations", x => x.AnimeId);
                });

            migrationBuilder.InsertData(
                table: "Animations",
                columns: new[] { "AnimeId", "Name", "PublishYear", "PublisherCountry", "PublisherName", "Rate", "WatchingYear" },
                values: new object[] { 1, "Demon Slayer", 2019, "Japan", "UFOTable", 4, 2020 });

            migrationBuilder.InsertData(
                table: "Animations",
                columns: new[] { "AnimeId", "Name", "PublishYear", "PublisherCountry", "PublisherName", "Rate", "WatchingYear" },
                values: new object[] { 2, "My NeighborTotoro", 1988, "Japan", "Ghibli", 5, 2007 });

            migrationBuilder.InsertData(
                table: "Animations",
                columns: new[] { "AnimeId", "Name", "PublishYear", "PublisherCountry", "PublisherName", "Rate", "WatchingYear" },
                values: new object[] { 3, "White Cat Legend", 2020, "China", "Nice Boat Animation Studio", 4, 2020 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animations");
        }
    }
}
