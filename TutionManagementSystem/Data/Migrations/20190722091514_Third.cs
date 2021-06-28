using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TutionManagementSystem.Data.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Student_StudentID",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Student_StudentID",
                table: "Teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_StudentID",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_StudentID",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Subjects");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "Teachers");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.AddColumn<int>(
                name: "SubjectID",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherID",
                table: "Students",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SubjectID",
                table: "Students",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeacherID",
                table: "Students",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Subjects_SubjectID",
                table: "Students",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_TeacherID",
                table: "Students",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Subjects_SubjectID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_TeacherID",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SubjectID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_TeacherID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TeacherID",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Teacher");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Teacher",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Subjects",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_StudentID",
                table: "Teacher",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_StudentID",
                table: "Subjects",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Student_StudentID",
                table: "Subjects",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Student_StudentID",
                table: "Teacher",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
