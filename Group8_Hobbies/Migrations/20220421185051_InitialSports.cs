using Microsoft.EntityFrameworkCore.Migrations;

namespace Group8_Hobbies.Migrations
{
    public partial class InitialSports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportsModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportsName = table.Column<string>(nullable: true),
                    SportsDescription = table.Column<string>(nullable: true),
                    TeamName = table.Column<string>(nullable: true),
                    TeamWins = table.Column<int>(nullable: false),
                    TeamLosses = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportsModelId);
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportsModelId", "SportsDescription", "SportsName", "TeamLosses", "TeamName", "TeamWins" },
                values: new object[,]
                {
                    { 1, "A sport where you score the ball into a basket 10 feet high from the ground", "Basketball", 29, "Golden State Warriors", 53 },
                    { 2, "A sport where you score the ball into a basket 10 feet high from the ground", "Basketball", 18, "Phoenix Suns", 64 },
                    { 3, "A sport where you score the ball into a basket 10 feet high from the ground", "Basketball", 26, "Memphis Grizzlies", 56 },
                    { 4, "A sport where you score the ball into a post with your foot", "Soccer", 3, "Manchester City", 24 },
                    { 5, "A sport where you score the ball into a post with your foot", "Soccer", 2, "Liverpool", 23 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
