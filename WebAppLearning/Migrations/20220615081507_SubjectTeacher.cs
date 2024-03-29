﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLearning.Migrations
{
    public partial class SubjectTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubjectTeacher",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubjectTeacher",
                table: "Student");
        }
    }
}
