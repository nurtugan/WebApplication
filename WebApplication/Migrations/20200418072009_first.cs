﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Poster = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -1, "Todd Phillips", new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crime , Drama , Thriller", "Joker", "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/joker_dabf394a-d4f2-4b68-90e2-011ed6b54012_poster.png?d=270x360&q=20" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -2, "David Leitch", new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Action , Adventure", "Fast & Furious Presents: Hobbs & Shaw", "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/fast-furious-presents-hobbs-shaw_14d1ab4f-c90c-46d1-9e04-f7d69f285ebd_poster.png?d=270x360&q=20" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -3, "Jon Favreau", new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adventure , Animation , Drama , Family , Musical", "The Lion King", "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/the-lion-king_3904aadc-3a07-4836-892f-763b2dfdeea3_poster.png?d=270x360&q=20" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -4, "Joachim Rønning", new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adventure , Family , Fantasy", "Maleficent: Mistress of Evil", "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/maleficent-mistress-of-evil_c8507e61-a6b3-404d-b8c5-df6f74bc62be_poster.png?d=270x360&q=20" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
