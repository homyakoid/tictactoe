using Microsoft.EntityFrameworkCore.Migrations;

namespace TicTacToe.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    IsOnline = table.Column<bool>(nullable: false),
                    IsPlaying = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.UniqueConstraint("AK_Users_NickName", x => x.NickName);
                });

            migrationBuilder.CreateTable(
                name: "Connections",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConnectionID = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connections", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Connections_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player1ID = table.Column<int>(nullable: true),
                    Player2ID = table.Column<int>(nullable: true),
                    Player1StatusID = table.Column<int>(nullable: true),
                    Player2StatusID = table.Column<int>(nullable: true),
                    IsOver = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Games_Users_Player1ID",
                        column: x => x.Player1ID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_PlayerStatuses_Player1StatusID",
                        column: x => x.Player1StatusID,
                        principalTable: "PlayerStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Users_Player2ID",
                        column: x => x.Player2ID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_PlayerStatuses_Player2StatusID",
                        column: x => x.Player2StatusID,
                        principalTable: "PlayerStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameResults",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameID = table.Column<int>(nullable: false),
                    PlayerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameResults", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GameResults_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameResults_Users_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameID = table.Column<int>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false),
                    MovePosition = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Moves_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Moves_Users_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "PlayerStatuses",
                columns: new[] { "ID", "Status" },
                values: new object[] { 1, "Pending" });

            migrationBuilder.InsertData(
                table: "PlayerStatuses",
                columns: new[] { "ID", "Status" },
                values: new object[] { 2, "Online" });

            migrationBuilder.InsertData(
                table: "PlayerStatuses",
                columns: new[] { "ID", "Status" },
                values: new object[] { 3, "Leave" });

            migrationBuilder.CreateIndex(
                name: "IX_Connections_UserID",
                table: "Connections",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_GameResults_GameID",
                table: "GameResults",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_GameResults_PlayerID",
                table: "GameResults",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Player1ID",
                table: "Games",
                column: "Player1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Player1StatusID",
                table: "Games",
                column: "Player1StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Player2ID",
                table: "Games",
                column: "Player2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Player2StatusID",
                table: "Games",
                column: "Player2StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_GameID",
                table: "Moves",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_PlayerID",
                table: "Moves",
                column: "PlayerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Connections");

            migrationBuilder.DropTable(
                name: "GameResults");

            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PlayerStatuses");
        }
    }
}
