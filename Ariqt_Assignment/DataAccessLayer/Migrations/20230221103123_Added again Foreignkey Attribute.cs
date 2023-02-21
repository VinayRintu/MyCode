using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddedagainForeignkeyAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments2_Courses2_CourseID",
                table: "Enrollments2");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments2_Students2_StudentID",
                table: "Enrollments2");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments2_CourseID",
                table: "Enrollments2");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments2_StudentID",
                table: "Enrollments2");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Enrollments2");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Enrollments2");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments2_E_CourseID",
                table: "Enrollments2",
                column: "E_CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments2_E_StudentID",
                table: "Enrollments2",
                column: "E_StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments2_Courses2_E_CourseID",
                table: "Enrollments2",
                column: "E_CourseID",
                principalTable: "Courses2",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments2_Students2_E_StudentID",
                table: "Enrollments2",
                column: "E_StudentID",
                principalTable: "Students2",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments2_Courses2_E_CourseID",
                table: "Enrollments2");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments2_Students2_E_StudentID",
                table: "Enrollments2");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments2_E_CourseID",
                table: "Enrollments2");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments2_E_StudentID",
                table: "Enrollments2");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Enrollments2",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Enrollments2",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments2_CourseID",
                table: "Enrollments2",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments2_StudentID",
                table: "Enrollments2",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments2_Courses2_CourseID",
                table: "Enrollments2",
                column: "CourseID",
                principalTable: "Courses2",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments2_Students2_StudentID",
                table: "Enrollments2",
                column: "StudentID",
                principalTable: "Students2",
                principalColumn: "StudentID");
        }
    }
}
