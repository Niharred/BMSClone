using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMSClone.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "theatres",
                columns: table => new
                {
                    TheatreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theatres", x => x.TheatreId);
                    table.ForeignKey(
                        name: "FK_theatres_cities_cityId",
                        column: x => x.cityId,
                        principalTable: "cities",
                        principalColumn: "CityId");
                });

            migrationBuilder.CreateTable(
                name: "movieLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movieLanguages_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_movieLanguages_movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movies",
                        principalColumn: "MovieId");
                });

            migrationBuilder.CreateTable(
                name: "halls",
                columns: table => new
                {
                    HallId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TheatreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halls", x => x.HallId);
                    table.ForeignKey(
                        name: "FK_halls_theatres_TheatreId",
                        column: x => x.TheatreId,
                        principalTable: "theatres",
                        principalColumn: "TheatreId");
                });

            migrationBuilder.CreateTable(
                name: "seats",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seatNumber = table.Column<int>(type: "int", nullable: false),
                    seatType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hallId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seats", x => x.SeatId);
                    table.ForeignKey(
                        name: "FK_seats_halls_hallId",
                        column: x => x.hallId,
                        principalTable: "halls",
                        principalColumn: "HallId");
                });

            migrationBuilder.CreateTable(
                name: "shows",
                columns: table => new
                {
                    ShowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    duration = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    theatreId = table.Column<int>(type: "int", nullable: false),
                    hallid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shows", x => x.ShowId);
                    table.ForeignKey(
                        name: "FK_shows_halls_hallid",
                        column: x => x.hallid,
                        principalTable: "halls",
                        principalColumn: "HallId");
                    table.ForeignKey(
                        name: "FK_shows_movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movies",
                        principalColumn: "MovieId");
                    table.ForeignKey(
                        name: "FK_shows_theatres_theatreId",
                        column: x => x.theatreId,
                        principalTable: "theatres",
                        principalColumn: "TheatreId");
                });

            migrationBuilder.CreateTable(
                name: "showSeats",
                columns: table => new
                {
                    ShowSeatsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowId = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_showSeats", x => x.ShowSeatsId);
                    table.ForeignKey(
                        name: "FK_showSeats_seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "seats",
                        principalColumn: "SeatId");
                    table.ForeignKey(
                        name: "FK_showSeats_shows_ShowId",
                        column: x => x.ShowId,
                        principalTable: "shows",
                        principalColumn: "ShowId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_halls_TheatreId",
                table: "halls",
                column: "TheatreId");

            migrationBuilder.CreateIndex(
                name: "IX_movieLanguages_LanguageId",
                table: "movieLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_movieLanguages_MovieId",
                table: "movieLanguages",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_seats_hallId",
                table: "seats",
                column: "hallId");

            migrationBuilder.CreateIndex(
                name: "IX_shows_hallid",
                table: "shows",
                column: "hallid");

            migrationBuilder.CreateIndex(
                name: "IX_shows_MovieId",
                table: "shows",
                column: "MovieId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_shows_theatreId",
                table: "shows",
                column: "theatreId");

            migrationBuilder.CreateIndex(
                name: "IX_showSeats_SeatId",
                table: "showSeats",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_showSeats_ShowId",
                table: "showSeats",
                column: "ShowId");

            migrationBuilder.CreateIndex(
                name: "IX_theatres_cityId",
                table: "theatres",
                column: "cityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movieLanguages");

            migrationBuilder.DropTable(
                name: "showSeats");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "seats");

            migrationBuilder.DropTable(
                name: "shows");

            migrationBuilder.DropTable(
                name: "halls");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "theatres");

            migrationBuilder.DropTable(
                name: "cities");
        }
    }
}
