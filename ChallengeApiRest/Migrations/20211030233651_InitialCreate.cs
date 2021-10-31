using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChallengeApiRest.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_Series",
                columns: table => new
                {
                    SeriesId = table.Column<int>(name: "Series Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesTitle = table.Column<string>(name: "Series Title", type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(name: "Creation Date", type: "datetime2", nullable: false),
                    Calification = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Series", x => x.SeriesId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(name: "Character Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterName = table.Column<string>(name: "Character Name", type: "nvarchar(max)", nullable: false),
                    CharacterAge = table.Column<int>(name: "Character Age", type: "int", nullable: false),
                    CharacterWeight = table.Column<double>(name: "Character Weight", type: "float", nullable: false),
                    CharacterStory = table.Column<string>(name: "Character Story", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(name: "Genre Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(name: "Genre Name", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSeries",
                columns: table => new
                {
                    RelatedSeriesid = table.Column<int>(type: "int", nullable: false),
                    relatedCharactersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSeries", x => new { x.RelatedSeriesid, x.relatedCharactersid });
                    table.ForeignKey(
                        name: "FK_CharacterSeries__Series_RelatedSeriesid",
                        column: x => x.RelatedSeriesid,
                        principalTable: "_Series",
                        principalColumn: "Series Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSeries_Characters_relatedCharactersid",
                        column: x => x.relatedCharactersid,
                        principalTable: "Characters",
                        principalColumn: "Character Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(name: "Movie Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTitle = table.Column<string>(name: "Movie Title", type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(name: "Creation Date", type: "datetime2", nullable: false),
                    Calification = table.Column<int>(type: "int", nullable: false),
                    Genreid = table.Column<int>(type: "int", nullable: true),
                    Genreid1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_Genreid",
                        column: x => x.Genreid,
                        principalTable: "Genres",
                        principalColumn: "Genre Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_Genreid1",
                        column: x => x.Genreid1,
                        principalTable: "Genres",
                        principalColumn: "Genre Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterMovie",
                columns: table => new
                {
                    RelatedMovieid = table.Column<int>(type: "int", nullable: false),
                    relatedCharactersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMovie", x => new { x.RelatedMovieid, x.relatedCharactersid });
                    table.ForeignKey(
                        name: "FK_CharacterMovie_Characters_relatedCharactersid",
                        column: x => x.relatedCharactersid,
                        principalTable: "Characters",
                        principalColumn: "Character Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMovie_Movies_RelatedMovieid",
                        column: x => x.RelatedMovieid,
                        principalTable: "Movies",
                        principalColumn: "Movie Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMovie_relatedCharactersid",
                table: "CharacterMovie",
                column: "relatedCharactersid");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSeries_relatedCharactersid",
                table: "CharacterSeries",
                column: "relatedCharactersid");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Genreid",
                table: "Movies",
                column: "Genreid");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Genreid1",
                table: "Movies",
                column: "Genreid1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterMovie");

            migrationBuilder.DropTable(
                name: "CharacterSeries");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "_Series");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
