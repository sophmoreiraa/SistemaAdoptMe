using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdoptMe.Migrations
{
    /// <inheritdoc />
    public partial class AjusteObs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ObeservacaoAnimal",
                table: "Animais",
                newName: "ObservacaoAnimal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ObservacaoAnimal",
                table: "Animais",
                newName: "ObeservacaoAnimal");
        }
    }
}
