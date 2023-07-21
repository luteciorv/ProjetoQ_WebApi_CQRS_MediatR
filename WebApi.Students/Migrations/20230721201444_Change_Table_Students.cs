using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Students.Migrations
{
    /// <inheritdoc />
    public partial class Change_Table_Students : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Perfil_Gender",
                table: "Students",
                newName: "Gender");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Students",
                newName: "Perfil_Gender");
        }
    }
}
