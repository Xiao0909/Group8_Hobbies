using Microsoft.EntityFrameworkCore.Migrations;

namespace Group8_Hobbies.Migrations
{
    public partial class Games : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GamesModelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(nullable: true),
                    GameGenre = table.Column<string>(nullable: true),
                    AvailablePlatform = table.Column<string>(nullable: true),
                    GamePublisher = table.Column<string>(nullable: true),
                    PersonalRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GamesModelID);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GamesModelID", "AvailablePlatform", "GameGenre", "GameName", "GamePublisher", "PersonalRating" },
                values: new object[,]
                {
                    { 1, "PS4/PS5/PC", "Open world Adventure/Action Role Playing Game", "Horizon: Zero Dawn", "Sony Interactive Entertainment", 9 },
                    { 2, "PS4/PS5", "Open world Adventure/Action Role Playing Game", "Ghost of Tsushima", "Sony Interactive Entertainment", 10 },
                    { 3, "PS4/PS5/PC/XBox 1/XBox Series S/X", "Open world Adventure/Action Role Playing Game", "Elden Ring", "Bandai Namco", 10 },
                    { 4, "All", "Open world Adventure/Action Role Playing Game", "Warframe", "Digital Extremes", 8 },
                    { 5, "All", "Action/Adventure", "Control", "505 Games", 9 },
                    { 6, "PS4/PS5/PC", "Action", "Sifu", "Sloclap", 7 },
                    { 7, "PS4/PS5/PC", "Action/Adventture", "God of War(2018)", "Sony Interactive Entertainment", 9 },
                    { 8, "All", "Puzzle/Platformer/Horror", "Little Nightmares", "Bandai Namco", 8 },
                    { 9, "PS4/PS5/PC/XBox 1/XBox Series S/X", "Action/Hack & Slash", "Sekiro: Shadows Die Twice", "Bandai Namco", 9 },
                    { 10, "PS4/PS5/PC/XBox 1/XBox Series S/X", "First Person Shooter/MMO", "Destiny 2", "Activision/Bungie", 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
