using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class againadding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollmentss_Coursess_CoursesCourseId",
                table: "Enrollmentss");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollmentss_Studentss_StudentsStudentId",
                table: "Enrollmentss");

            migrationBuilder.DropIndex(
                name: "IX_Enrollmentss_CoursesCourseId",
                table: "Enrollmentss");

            migrationBuilder.DropIndex(
                name: "IX_Enrollmentss_StudentsStudentId",
                table: "Enrollmentss");

            migrationBuilder.DropColumn(
                name: "CoursesCourseId",
                table: "Enrollmentss");

            migrationBuilder.DropColumn(
                name: "StudentsStudentId",
                table: "Enrollmentss");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoursesCourseId",
                table: "Enrollmentss",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentsStudentId",
                table: "Enrollmentss",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollmentss_CoursesCourseId",
                table: "Enrollmentss",
                column: "CoursesCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollmentss_StudentsStudentId",
                table: "Enrollmentss",
                column: "StudentsStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollmentss_Coursess_CoursesCourseId",
                table: "Enrollmentss",
                column: "CoursesCourseId",
                principalTable: "Coursess",
                principalColumn: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollmentss_Studentss_StudentsStudentId",
                table: "Enrollmentss",
                column: "StudentsStudentId",
                principalTable: "Studentss",
                principalColumn: "StudentId");
        }
    }
}
