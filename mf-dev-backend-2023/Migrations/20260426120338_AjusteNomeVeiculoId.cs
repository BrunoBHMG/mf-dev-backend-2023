using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_dev_backend_2023.Migrations
{
    /// <inheritdoc />
    public partial class AjusteNomeVeiculoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumos_Veiculos_VeiculoId",
                table: "Consumos");

            migrationBuilder.DropColumn(
                name: "VeiculoIs",
                table: "Consumos");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Consumos",
                newName: "Data");

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "Consumos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Consumos_Veiculos_VeiculoId",
                table: "Consumos",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumos_Veiculos_VeiculoId",
                table: "Consumos");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Consumos",
                newName: "data");

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "Consumos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "VeiculoIs",
                table: "Consumos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Consumos_Veiculos_VeiculoId",
                table: "Consumos",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id");
        }
    }
}
