using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses2",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses2", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Students2",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students2", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments2",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EStudentID = table.Column<int>(name: "E_StudentID", type: "int", nullable: false),
                    ECourseID = table.Column<int>(name: "E_CourseID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments2", x => x.EnrollmentID);
                    table.ForeignKey(
                        name: "FK_Enrollments2_Courses2_E_CourseID",
                        column: x => x.ECourseID,
                        principalTable: "Courses2",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments2_Students2_E_StudentID",
                        column: x => x.EStudentID,
                        principalTable: "Students2",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments2_E_CourseID",
                table: "Enrollments2",
                column: "E_CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments2_E_StudentID",
                table: "Enrollments2",
                column: "E_StudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments2");

            migrationBuilder.DropTable(
                name: "Courses2");

            migrationBuilder.DropTable(
                name: "Students2");
        }
    }
}
