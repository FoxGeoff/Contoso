using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ContosoUniversity.Migrations
{
    public partial class ModStudentDataDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnrollmentDate",
                table: "Students",
                newName: "enrollment_date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "enrollment_date",
                table: "Students",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "enrollment_date",
                table: "Students",
                newName: "EnrollmentDate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EnrollmentDate",
                table: "Students",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}
