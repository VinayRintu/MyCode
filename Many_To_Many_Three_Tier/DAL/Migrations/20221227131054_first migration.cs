using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coursess",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coursess", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Studentss",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Standard = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentss", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Enrollmentss",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CoursesCourseId = table.Column<int>(type: "int", nullable: true),
                    StudentsStudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollmentss", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollmentss_Coursess_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalTable: "Coursess",
                        principalColumn: "CourseId");
                    table.ForeignKey(
                        name: "FK_Enrollmentss_Studentss_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalTable: "Studentss",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollmentss_CoursesCourseId",
                table: "Enrollmentss",
                column: "CoursesCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollmentss_StudentsStudentId",
                table: "Enrollmentss",
                column: "StudentsStudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollmentss");

            migrationBuilder.DropTable(
                name: "Coursess");

            migrationBuilder.DropTable(
                name: "Studentss");
        }
    }
}
