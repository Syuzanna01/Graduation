using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Graduation.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstituteId",
                table: "Sections",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_InstituteId",
                table: "Sections",
                column: "InstituteId");

            migrationBuilder.CreateIndex(
                name: "IX_Institutes_PulpitId",
                table: "Institutes",
                column: "PulpitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Institutes_Pulpits_PulpitId",
                table: "Institutes",
                column: "PulpitId",
                principalTable: "Pulpits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Institutes_InstituteId",
                table: "Sections",
                column: "InstituteId",
                principalTable: "Institutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Institutes_Pulpits_PulpitId",
                table: "Institutes");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Institutes_InstituteId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_InstituteId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Institutes_PulpitId",
                table: "Institutes");

            migrationBuilder.DropColumn(
                name: "InstituteId",
                table: "Sections");
        }
    }
}
