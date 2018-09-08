﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class seedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make 1')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make 2')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make 3')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make 1-Model A', (SELECT ID FROM MAKES WHERE NAME = 'Make 1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make 1-Model B', (SELECT ID FROM MAKES WHERE NAME = 'Make 1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make 1-Model C', (SELECT ID FROM MAKES WHERE NAME = 'Make 1'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make 2-Model A', (SELECT ID FROM MAKES WHERE NAME = 'Make 2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make 2-Model B', (SELECT ID FROM MAKES WHERE NAME = 'Make 2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make 2-Model C', (SELECT ID FROM MAKES WHERE NAME = 'Make 2'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make 3-Model A', (SELECT ID FROM MAKES WHERE NAME = 'Make 3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make 3-Model B', (SELECT ID FROM MAKES WHERE NAME = 'Make 3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make 3-Model C', (SELECT ID FROM MAKES WHERE NAME = 'Make 3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Make 1', 'Make 2', 'Make 3'");
        }
    }
}
