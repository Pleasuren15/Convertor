using Microsoft.EntityFrameworkCore.Migrations;

namespace Convertor.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Conversions",
                columns: table => new
                {
                    ConversionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConversionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConversionFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConversionFromValue = table.Column<double>(type: "float", nullable: false),
                    ConversionTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConversionToValue = table.Column<double>(type: "float", nullable: false),
                    ConversionFormula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isConversionRequest = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversions", x => x.ConversionId);
                    table.ForeignKey(
                        name: "FK_Conversions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "CategoryUrl" },
                values: new object[,]
                {
                    { 1, "Celsius, Fahrenheit, Kelvin & more units", "Temperature", "https://img.icons8.com/nolan/64/temperature.png" },
                    { 2, "Pounds, Kilograms, Ounces, Stone & more units", "Weight", "https://img.icons8.com/nolan/64/weight-kg.png" },
                    { 3, "Miles, Kilometres, Metres, Feet, Inches, Centimetres & more units", "Length", "https://img.icons8.com/nolan/64/ruler.png" },
                    { 4, "Hectares, Square Feet, Square Metres, Acres & more units", "Area", "https://img.icons8.com/nolan/64/pi.png" },
                    { 5, "US Gallos, US Pints, Litres, Milliliters, UK Pints & more units", "Volume", "https://img.icons8.com/nolan/64/scales.png" },
                    { 6, "Kilometres per hour, Miles per hour, Knots & more units", "Speed", "https://img.icons8.com/nolan/64/speed.png" },
                    { 7, "Seconds, Minutes, Hours & more units", "Time", "https://img.icons8.com/nolan/64/time.png" },
                    { 8, "Radians, Degrees & more units", "Angle", "https://img.icons8.com/nolan/64/trigonometry.png" }
                });

            migrationBuilder.InsertData(
                table: "Conversions",
                columns: new[] { "ConversionId", "CategoryId", "ConversionFormula", "ConversionFrom", "ConversionFromValue", "ConversionName", "ConversionTo", "ConversionToValue", "isConversionRequest" },
                values: new object[,]
                {
                    { "CelToFah", 1, "(0°C × 9/5) + 32 = 32°F", "Celsius", 0.0, "Celsius to Fahrenheit", "Fahrenheit", 0.0, false },
                    { "HecToSqu", 4, "multiply the area value by 107639", "Hectares", 0.0, "Hectares to Square Feet", "Square Feet", 0.0, false },
                    { "SquToHec", 4, "divide the area value by 107639", "Square Feet", 0.0, "Square Feet to Hectares", "Hectares", 0.0, false },
                    { "KphToMph", 6, "divide the speed value by 1,609", "Kilometers per hour", 0.0, "Kilometers per hour to Miles per hour", "Miles per hour", 0.0, false },
                    { "MphToKph", 6, "multiply the speed value by 1,609", "Miles per hour", 0.0, "Miles per hour to Kilometers per hour", "Kilometers per hour", 0.0, false },
                    { "MpsToMph", 6, "multiply the speed value by 2,237", "Meters per second", 0.0, "Meters per second to Miles per hour", "Miles per hour", 0.0, false },
                    { "MphToMps", 6, "divide the speed value by 2,237", "Miles per hour", 0.0, "Miles per hour to Meters per second", "Meters per second", 0.0, false },
                    { "MpsToKps", 6, "multiply the speed value by 3,6", "Meters per second", 0.0, "Meters per second to Kilometers per hour", "Kilometers per hour", 0.0, false },
                    { "KpsToMps", 6, "divide the speed value by 3,6", "Kilometers per hour", 0.0, "Kilometers per hour to Meters per second", "Meters per second", 0.0, false },
                    { "AcrToHec", 4, "divide the area value by 2,471", "Acres", 0.0, "Acres to Hectares", "Hectares", 0.0, false },
                    { "SecToMin", 7, "divide the time value by 60", "Second", 0.0, "Second to Minute", "Minute", 0.0, false },
                    { "SecToHou", 7, "divide the time value by 3600", "Second", 0.0, "Second to Hour", "Hour", 0.0, false },
                    { "HouToSec", 7, "multiply the time value by 3600", "Hour", 0.0, "Hour to Second", "Second", 0.0, false },
                    { "MinToHou", 7, "divide the time value by 60", "Minute", 0.0, "Minute to Hour", "Hour", 0.0, false },
                    { "HouToMin", 7, "multiply the time value by 60", "Hour", 0.0, "Hour to Min", "Minute", 0.0, false },
                    { "DayToHou", 7, "multiply the time value by 24", "Day", 0.0, "Day to Hour", "Hour", 0.0, true },
                    { "HouToDay", 7, "divide the mass value by 24", "Hour", 0.0, "Hour to Day", "Day", 0.0, true },
                    { "DegToRad", 8, "1Deg × π/180 = 0,01745Rad", "Degrees", 0.0, "Degrees to Radians", "Radians", 0.0, false },
                    { "RadToDeg", 8, "1Rad × 180/π = 57,296Deg", "Radians", 0.0, "Radians to Degrees", "Degrees", 0.0, false },
                    { "MinToSec", 7, "multiply the time value by 60", "Minute", 0.0, "Minute to Second", "Second", 0.0, false },
                    { "HecToAcr", 4, "multiply the area value by 2,471", "Hectares", 0.0, "Hectares to Acres", "Acres", 0.0, false },
                    { "AcrToSqu", 4, "multiply the area value by 43560", "Acres", 0.0, "Acres to Square Feet", "Square Feet", 0.0, false },
                    { "SquToAcr", 4, "divide the area value by 43560", "Square Feet", 0.0, "Square Feet to Acres", "Acres", 0.0, false },
                    { "FahToCel", 1, "(32°F − 32) × 5/9 = 0°C", "Fahrenheit", 0.0, "Fahrenheit to Celsius", "Celsius", 0.0, false },
                    { "CelToKel", 1, "0°C + 273.15 = 273,15K", "Celsius", 0.0, "Celsius to Kelvin", "Kelvin", 0.0, false },
                    { "KelToCel", 1, "0K − 273.15 = -273,1°C", "Kelvin", 0.0, "Kelvin to Celsius", "Celsius", 0.0, false },
                    { "FahToKel", 1, "(32°F − 32) × 5/9 + 273.15 = 273,15K", "Fahrenheit", 0.0, "Fahrenheit to Kelvin", "Kelvin", 0.0, false },
                    { "KelToFah", 1, "(0K − 273.15) × 9/5 + 32 = -459,7°F", "Kelvin", 0.0, "Kelvin to Fahrenheit", "Fahrenheit", 0.0, false },
                    { "DelToFah", 1, "[°De] = (373.15 − [K]) × ​3⁄2", "Delisle", 0.0, "Delisle to Fahrenheit", "Fahrenheit", 0.0, true },
                    { "FahToDel", 1, "[K] = 373.15 − [°De] × ​2⁄3", "Fahrenheit", 0.0, "Fahrenheit to Delisle", "Delisle", 0.0, true },
                    { "GraToOun", 2, "divide the mass value by 28,35", "Grams", 0.0, "Grams to Ounces", "Ounces", 0.0, true },
                    { "OunToGra", 2, "multiply the mass value by 28,35", "Ounces", 0.0, "Ounces to Grams", "Grams", 0.0, true },
                    { "MetToFee", 3, "multiply the length value by 3,281", "Meters", 0.0, "Meters to Feet", "Feet", 0.0, false },
                    { "FeeToMet", 3, "divide the length value by 3,281", "Feet", 0.0, "Feet to Meters", "Meters", 0.0, false },
                    { "IncToCen", 3, "multiply the length value by 2,54", "Inches", 0.0, "Inches to Centimeters", "Centimeters", 0.0, false },
                    { "CenToInc", 3, "divide the length value by 2,54", "Centimeters", 0.0, "Centimeters to Inches", "Inches", 0.0, false },
                    { "MilToInc", 3, "divide the length value by 25,4", "Millimeters", 0.0, "Millimeters to Inches", "Inches", 0.0, false },
                    { "IncToMil", 3, "multiply the length value by 25,4", "Inches", 0.0, "Inches to Millimeters", "Millimeters", 0.0, false },
                    { "IncToFee", 3, "divide the length value by 12", "Inches", 0.0, "Inches to Feet", "Feet", 0.0, false },
                    { "FeeToInc", 3, "multiply the length value by 12", "Feet", 0.0, "Feet to Inches", "Inches", 0.0, false },
                    { "MilToKil", 3, "multiply the speed value by 1,609", "Miles", 0.0, "Miles to Kilometers", "Kilometers", 0.0, false },
                    { "KilToMil", 3, "divide the speed value by 1,609", "Kilometers", 0.0, "Kilometers to Miles", "Miles", 0.0, false }
                });

            migrationBuilder.InsertData(
                table: "Conversions",
                columns: new[] { "ConversionId", "CategoryId", "ConversionFormula", "ConversionFrom", "ConversionFromValue", "ConversionName", "ConversionTo", "ConversionToValue", "isConversionRequest" },
                values: new object[] { "GraToRad", 8, "1Grad × π/200 = 0,01571Rad", "Gradians", 0.0, "Gradians to Radians", "Radians", 0.0, false });

            migrationBuilder.InsertData(
                table: "Conversions",
                columns: new[] { "ConversionId", "CategoryId", "ConversionFormula", "ConversionFrom", "ConversionFromValue", "ConversionName", "ConversionTo", "ConversionToValue", "isConversionRequest" },
                values: new object[] { "RadToGra", 8, "1Rad × 200/π = 63,662Grad", "Radians", 0.0, "Radians to Gradians", "Gradians", 0.0, false });

            migrationBuilder.CreateIndex(
                name: "IX_Conversions_CategoryId",
                table: "Conversions",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conversions");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
