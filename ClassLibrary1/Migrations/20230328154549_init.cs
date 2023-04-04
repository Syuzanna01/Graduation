using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Graduation.DAL.Migrations
{
    /// <inheritdoc />
    public partial class INIT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Institutes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Institute = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lecturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
<<<<<<<< HEAD:ClassLibrary1/Migrations/20230404175546_INIT.cs
                name: "Subjects",
========
                name: "Chairs",
>>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f:ClassLibrary1/Migrations/20230328154549_init.cs
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
<<<<<<<< HEAD:ClassLibrary1/Migrations/20230404175546_INIT.cs
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Credit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chairs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Chairs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstituteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
========
                    Chairs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstituteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
>>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f:ClassLibrary1/Migrations/20230328154549_init.cs
                    table.PrimaryKey("PK_Chairs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chairs_Institutes_InstituteId",
                        column: x => x.InstituteId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChairsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Chairs_ChairsId",
                        column: x => x.ChairsId,
                        principalTable: "Chairs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LecturerGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LecturerId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturerGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LecturerGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturerGroups_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

<<<<<<<< HEAD:ClassLibrary1/Migrations/20230404175546_INIT.cs
            migrationBuilder.CreateTable(
                name: "Gradeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course = table.Column<int>(type: "int", nullable: false),
                    Subject1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Graded1 = table.Column<int>(type: "int", nullable: false),
                    Subject2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Graded2 = table.Column<int>(type: "int", nullable: false),
                    Subject3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Graded3 = table.Column<int>(type: "int", nullable: false),
                    Subject4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Graded4 = table.Column<int>(type: "int", nullable: false),
                    Mog = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gradeds_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

========
>>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f:ClassLibrary1/Migrations/20230328154549_init.cs
            migrationBuilder.CreateIndex(
                name: "IX_Chairs_InstituteId",
                table: "Chairs",
                column: "InstituteId");

            migrationBuilder.CreateIndex(
<<<<<<<< HEAD:ClassLibrary1/Migrations/20230404175546_INIT.cs
                name: "IX_Gradeds_StudentId",
                table: "Gradeds",
                column: "StudentId");

            migrationBuilder.CreateIndex(
========
>>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f:ClassLibrary1/Migrations/20230328154549_init.cs
                name: "IX_Groups_SectionId",
                table: "Groups",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturerGroups_GroupId",
                table: "LecturerGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturerGroups_LecturerId",
                table: "LecturerGroups",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_ChairsId",
                table: "Sections",
                column: "ChairsId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
<<<<<<<< HEAD:ClassLibrary1/Migrations/20230404175546_INIT.cs
                name: "Gradeds");

            migrationBuilder.DropTable(
                name: "LecturerGroups");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
========
                name: "LecturerGroups");

            migrationBuilder.DropTable(
>>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f:ClassLibrary1/Migrations/20230328154549_init.cs
                name: "Students");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Chairs");

            migrationBuilder.DropTable(
                name: "Institutes");
        }
    }
}
