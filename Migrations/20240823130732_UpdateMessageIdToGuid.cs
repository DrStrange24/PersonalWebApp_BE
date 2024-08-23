﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalWebApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMessageIdToGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageId",
                table: "Messages",
                newName: "Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Messages",
                type: "char(36)",
                nullable: false,
                defaultValueSql: "(UUID())"
            );

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Products",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldDefaultValueSql: "UUID()")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Messages",
                newName: "MessageId");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Products",
                type: "char(36)",
                nullable: false,
                defaultValueSql: "UUID()",
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");
        }
    }
}
