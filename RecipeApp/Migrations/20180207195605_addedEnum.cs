using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RecipeApp.Migrations
{
    public partial class addedEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Recipe");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Directions",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ingredient = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    RecipeID = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipe_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeID",
                table: "Ingredients",
                column: "RecipeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Directions",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Recipe",
                nullable: true);
        }
    }
}
