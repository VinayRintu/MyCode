using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddingEnrollment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses1_Students1_StudentID",
                table: "Courses1");

            migrationBuilder.DropIndex(
                name: "IX_Courses1_StudentID",
                table: "Courses1");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Courses1");

            migrationBuilder.CreateTable(
                name: "Enrollments1",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments1", x => x.EnrollmentID);
                    table.ForeignKey(
                        name: "FK_Enrollments1_Courses1_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses1",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments1_Students1_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students1",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments1_CourseId",
                table: "Enrollments1",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments1_StudentId",
                table: "Enrollments1",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments1");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Courses1",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses1_StudentID",
                table: "Courses1",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses1_Students1_StudentID",
                table: "Courses1",
                column: "StudentID",
                principalTable: "Students1",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
