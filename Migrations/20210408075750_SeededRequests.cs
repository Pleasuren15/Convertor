using Microsoft.EntityFrameworkCore.Migrations;

namespace Convertor.Migrations
{
    public partial class SeededRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ConversionTo",
                table: "Conversions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConversionName",
                table: "Conversions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConversionFrom",
                table: "Conversions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConversionFormula",
                table: "Conversions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "AcrToHec",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "AcrToSqu",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "CelToFah",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "CelToKel",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "CenToInc",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "DegToRad",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "FahToCel",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "FahToKel",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "FeeToInc",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "FeeToMet",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "GraToRad",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "HecToAcr",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "HecToSqu",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "HouToMin",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "HouToSec",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "IncToCen",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "IncToFee",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "IncToMil",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "KelToCel",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "KelToFah",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "KilToMil",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "KphToMph",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "KpsToMps",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MetToFee",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MilToInc",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MilToKil",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MinToHou",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MinToSec",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MphToKph",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MphToMps",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MpsToKps",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MpsToMph",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "RadToDeg",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "RadToGra",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "SecToHou",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "SecToMin",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "SquToAcr",
                column: "isConversionRequest",
                value: true);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "SquToHec",
                column: "isConversionRequest",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ConversionTo",
                table: "Conversions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ConversionName",
                table: "Conversions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ConversionFrom",
                table: "Conversions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ConversionFormula",
                table: "Conversions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "AcrToHec",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "AcrToSqu",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "CelToFah",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "CelToKel",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "CenToInc",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "DegToRad",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "FahToCel",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "FahToKel",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "FeeToInc",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "FeeToMet",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "GraToRad",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "HecToAcr",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "HecToSqu",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "HouToMin",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "HouToSec",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "IncToCen",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "IncToFee",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "IncToMil",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "KelToCel",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "KelToFah",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "KilToMil",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "KphToMph",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "KpsToMps",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MetToFee",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MilToInc",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MilToKil",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MinToHou",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MinToSec",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MphToKph",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MphToMps",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MpsToKps",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "MpsToMph",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "RadToDeg",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "RadToGra",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "SecToHou",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "SecToMin",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "SquToAcr",
                column: "isConversionRequest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Conversions",
                keyColumn: "ConversionId",
                keyValue: "SquToHec",
                column: "isConversionRequest",
                value: false);
        }
    }
}
