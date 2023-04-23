using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baithuchanh1704.Migrations
{
    /// <inheritdoc />
    public partial class Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adđress",
                columns: table => new
                {
                    AddressID = table.Column<string>(type: "TEXT", nullable: false),
                    AddressNane = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adđress", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    FacultyID = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.FacultyID);
                });

            migrationBuilder.CreateTable(
                name: "Sex",
                columns: table => new
                {
                    SexID = table.Column<string>(type: "TEXT", nullable: false),
                    SexName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sex", x => x.SexID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<string>(type: "TEXT", nullable: false),
                    StudentName = table.Column<string>(type: "TEXT", nullable: false),
                    SexID = table.Column<string>(type: "TEXT", nullable: false),
                    AddressID = table.Column<string>(type: "TEXT", nullable: false),
                    FacultyID = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Student_Adđress_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Adđress",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Faculty_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Sex_SexID",
                        column: x => x.SexID,
                        principalTable: "Sex",
                        principalColumn: "SexID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_AddressID",
                table: "Student",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_FacultyID",
                table: "Student",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_SexID",
                table: "Student",
                column: "SexID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Adđress");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Sex");
        }
    }
}
