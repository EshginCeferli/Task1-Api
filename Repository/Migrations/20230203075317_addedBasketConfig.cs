﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedBasketConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Friday, February 3, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Wednesday, February 1, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "02/03/2023 07:53:17",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "02/01/2023 15:57:37");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BasketProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Friday, February 3, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Wednesday, February 1, 2023");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Basket",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Basket",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Friday, February 3, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Wednesday, February 1, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Friday, February 3, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "02/01/2023 15:57:37",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "02/03/2023 07:53:17");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BasketProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Wednesday, February 1, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Friday, February 3, 2023");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Basket",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Basket",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Friday, February 3, 2023");
        }
    }
}
