using Microsoft.EntityFrameworkCore.Migrations;

namespace Convertor.Migrations
{
    public partial class isConversionRequestFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "KilToMil",
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
                keyValue: "RadToDeg",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "KilToMil",
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
                keyValue: "RadToDeg",
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
        }
    }
}
