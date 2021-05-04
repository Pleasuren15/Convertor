﻿// <auto-generated />
using Convertor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Convertor.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210408075750_SeededRequests")]
    partial class SeededRequests
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Convertor.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "Celsius, Fahrenheit, Kelvin & more units",
                            CategoryName = "Temperature",
                            CategoryUrl = "https://img.icons8.com/nolan/64/temperature.png"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "Pounds, Kilograms, Ounces, Stone & more units",
                            CategoryName = "Weight",
                            CategoryUrl = "https://img.icons8.com/nolan/64/weight-kg.png"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "Miles, Kilometres, Metres, Feet, Inches, Centimetres & more units",
                            CategoryName = "Length",
                            CategoryUrl = "https://img.icons8.com/nolan/64/ruler.png"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryDescription = "Hectares, Square Feet, Square Metres, Acres & more units",
                            CategoryName = "Area",
                            CategoryUrl = "https://img.icons8.com/nolan/64/pi.png"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryDescription = "US Gallos, US Pints, Litres, Milliliters, UK Pints & more units",
                            CategoryName = "Volume",
                            CategoryUrl = "https://img.icons8.com/nolan/64/scales.png"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryDescription = "Kilometres per hour, Miles per hour, Knots & more units",
                            CategoryName = "Speed",
                            CategoryUrl = "https://img.icons8.com/nolan/64/speed.png"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryDescription = "Seconds, Minutes, Hours & more units",
                            CategoryName = "Time",
                            CategoryUrl = "https://img.icons8.com/nolan/64/time.png"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryDescription = "Radians, Degrees & more units",
                            CategoryName = "Angle",
                            CategoryUrl = "https://img.icons8.com/nolan/64/trigonometry.png"
                        });
                });

            modelBuilder.Entity("Convertor.Models.Conversion", b =>
                {
                    b.Property<string>("ConversionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ConversionFormula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConversionFrom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ConversionFromValue")
                        .HasColumnType("float");

                    b.Property<string>("ConversionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConversionTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ConversionToValue")
                        .HasColumnType("float");

                    b.Property<bool>("isConversionRequest")
                        .HasColumnType("bit");

                    b.HasKey("ConversionId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Conversions");

                    b.HasData(
                        new
                        {
                            ConversionId = "CelToFah",
                            CategoryId = 1,
                            ConversionFormula = "(0°C × 9/5) + 32 = 32°F",
                            ConversionFrom = "Celsius",
                            ConversionFromValue = 0.0,
                            ConversionName = "Celsius to Fahrenheit",
                            ConversionTo = "Fahrenheit",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "FahToCel",
                            CategoryId = 1,
                            ConversionFormula = "(32°F − 32) × 5/9 = 0°C",
                            ConversionFrom = "Fahrenheit",
                            ConversionFromValue = 0.0,
                            ConversionName = "Fahrenheit to Celsius",
                            ConversionTo = "Celsius",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "CelToKel",
                            CategoryId = 1,
                            ConversionFormula = "0°C + 273.15 = 273,15K",
                            ConversionFrom = "Celsius",
                            ConversionFromValue = 0.0,
                            ConversionName = "Celsius to Kelvin",
                            ConversionTo = "Kelvin",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "KelToCel",
                            CategoryId = 1,
                            ConversionFormula = "0K − 273.15 = -273,1°C",
                            ConversionFrom = "Kelvin",
                            ConversionFromValue = 0.0,
                            ConversionName = "Kelvin to Celsius",
                            ConversionTo = "Celsius",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "DegToRad",
                            CategoryId = 8,
                            ConversionFormula = "1Deg × π/180 = 0,01745Rad",
                            ConversionFrom = "Degrees",
                            ConversionFromValue = 0.0,
                            ConversionName = "Degrees to Radians",
                            ConversionTo = "Radians",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "RadToDeg",
                            CategoryId = 8,
                            ConversionFormula = "1Rad × 180/π = 57,296Deg",
                            ConversionFrom = "Radians",
                            ConversionFromValue = 0.0,
                            ConversionName = "Radians to Degrees",
                            ConversionTo = "Degrees",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "SquToAcr",
                            CategoryId = 4,
                            ConversionFormula = "divide the area value by 43560",
                            ConversionFrom = "Square Feet",
                            ConversionFromValue = 0.0,
                            ConversionName = "Square Feet to Acres",
                            ConversionTo = "Acres",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "AcrToSqu",
                            CategoryId = 4,
                            ConversionFormula = "multiply the area value by 43560",
                            ConversionFrom = "Acres",
                            ConversionFromValue = 0.0,
                            ConversionName = "Acres to Square Feet",
                            ConversionTo = "Square Feet",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "MetToFee",
                            CategoryId = 3,
                            ConversionFormula = "multiply the length value by 3,281",
                            ConversionFrom = "Meters",
                            ConversionFromValue = 0.0,
                            ConversionName = "Meters to Feet",
                            ConversionTo = "Feet",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "FeeToMet",
                            CategoryId = 3,
                            ConversionFormula = "divide the length value by 3,281",
                            ConversionFrom = "Feet",
                            ConversionFromValue = 0.0,
                            ConversionName = "Feet to Meters",
                            ConversionTo = "Meters",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "IncToCen",
                            CategoryId = 3,
                            ConversionFormula = "multiply the length value by 2,54",
                            ConversionFrom = "Inches",
                            ConversionFromValue = 0.0,
                            ConversionName = "Inches to Centimeters",
                            ConversionTo = "Centimeters",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "CenToInc",
                            CategoryId = 3,
                            ConversionFormula = "divide the length value by 2,54",
                            ConversionFrom = "Centimeters",
                            ConversionFromValue = 0.0,
                            ConversionName = "Centimeters to Inches",
                            ConversionTo = "Inches",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "MilToInc",
                            CategoryId = 3,
                            ConversionFormula = "divide the length value by 25,4",
                            ConversionFrom = "Millimeters",
                            ConversionFromValue = 0.0,
                            ConversionName = "Millimeters to Inches",
                            ConversionTo = "Inches",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "IncToMil",
                            CategoryId = 3,
                            ConversionFormula = "multiply the length value by 25,4",
                            ConversionFrom = "Inches",
                            ConversionFromValue = 0.0,
                            ConversionName = "Inches to Millimeters",
                            ConversionTo = "Millimeters",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "IncToFee",
                            CategoryId = 3,
                            ConversionFormula = "divide the length value by 12",
                            ConversionFrom = "Inches",
                            ConversionFromValue = 0.0,
                            ConversionName = "Inches to Feet",
                            ConversionTo = "Feet",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "FeeToInc",
                            CategoryId = 3,
                            ConversionFormula = "multiply the length value by 12",
                            ConversionFrom = "Feet",
                            ConversionFromValue = 0.0,
                            ConversionName = "Feet to Inches",
                            ConversionTo = "Inches",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "MilToKil",
                            CategoryId = 3,
                            ConversionFormula = "multiply the speed value by 1,609",
                            ConversionFrom = "Miles",
                            ConversionFromValue = 0.0,
                            ConversionName = "Miles to Kilometers",
                            ConversionTo = "Kilometers",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "KilToMil",
                            CategoryId = 3,
                            ConversionFormula = "divide the speed value by 1,609",
                            ConversionFrom = "Kilometers",
                            ConversionFromValue = 0.0,
                            ConversionName = "Kilometers to Miles",
                            ConversionTo = "Miles",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "SecToMin",
                            CategoryId = 7,
                            ConversionFormula = "divide the time value by 60",
                            ConversionFrom = "Second",
                            ConversionFromValue = 0.0,
                            ConversionName = "Second to Minute",
                            ConversionTo = "Minute",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "MinToSec",
                            CategoryId = 7,
                            ConversionFormula = "multiply the time value by 60",
                            ConversionFrom = "Minute",
                            ConversionFromValue = 0.0,
                            ConversionName = "Minute to Second",
                            ConversionTo = "Second",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "SecToHou",
                            CategoryId = 7,
                            ConversionFormula = "divide the time value by 3600",
                            ConversionFrom = "Second",
                            ConversionFromValue = 0.0,
                            ConversionName = "Second to Hour",
                            ConversionTo = "Hour",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "HouToSec",
                            CategoryId = 7,
                            ConversionFormula = "multiply the time value by 3600",
                            ConversionFrom = "Hour",
                            ConversionFromValue = 0.0,
                            ConversionName = "Hour to Second",
                            ConversionTo = "Second",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "MinToHou",
                            CategoryId = 7,
                            ConversionFormula = "divide the time value by 60",
                            ConversionFrom = "Minute",
                            ConversionFromValue = 0.0,
                            ConversionName = "Minute to Hour",
                            ConversionTo = "Hour",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "HouToMin",
                            CategoryId = 7,
                            ConversionFormula = "multiply the time value by 60",
                            ConversionFrom = "Hour",
                            ConversionFromValue = 0.0,
                            ConversionName = "Hour to Min",
                            ConversionTo = "Minute",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "GraToRad",
                            CategoryId = 8,
                            ConversionFormula = "1Grad × π/200 = 0,01571Rad",
                            ConversionFrom = "Gradians",
                            ConversionFromValue = 0.0,
                            ConversionName = "Gradians to Radians",
                            ConversionTo = "Radians",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "RadToGra",
                            CategoryId = 8,
                            ConversionFormula = "1Rad × 200/π = 63,662Grad",
                            ConversionFrom = "Radians",
                            ConversionFromValue = 0.0,
                            ConversionName = "Radians to Gradians",
                            ConversionTo = "Gradians",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "HecToAcr",
                            CategoryId = 4,
                            ConversionFormula = "multiply the area value by 2,471",
                            ConversionFrom = "Hectares",
                            ConversionFromValue = 0.0,
                            ConversionName = "Hectares to Acres",
                            ConversionTo = "Acres",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "AcrToHec",
                            CategoryId = 4,
                            ConversionFormula = "divide the area value by 2,471",
                            ConversionFrom = "Acres",
                            ConversionFromValue = 0.0,
                            ConversionName = "Acres to Hectares",
                            ConversionTo = "Hectares",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "HecToSqu",
                            CategoryId = 4,
                            ConversionFormula = "multiply the area value by 107639",
                            ConversionFrom = "Hectares",
                            ConversionFromValue = 0.0,
                            ConversionName = "Hectares to Square Feet",
                            ConversionTo = "Square Feet",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "SquToHec",
                            CategoryId = 4,
                            ConversionFormula = "divide the area value by 107639",
                            ConversionFrom = "Square Feet",
                            ConversionFromValue = 0.0,
                            ConversionName = "Square Feet to Hectares",
                            ConversionTo = "Hectares",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "KphToMph",
                            CategoryId = 6,
                            ConversionFormula = "divide the speed value by 1,609",
                            ConversionFrom = "Kilometers per hour",
                            ConversionFromValue = 0.0,
                            ConversionName = "Kilometers per hour to Miles per hour",
                            ConversionTo = "Miles per hour",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "MphToKph",
                            CategoryId = 6,
                            ConversionFormula = "multiply the speed value by 1,609",
                            ConversionFrom = "Miles per hour",
                            ConversionFromValue = 0.0,
                            ConversionName = "Miles per hour to Kilometers per hour",
                            ConversionTo = "Kilometers per hour",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "MpsToMph",
                            CategoryId = 6,
                            ConversionFormula = "multiply the speed value by 2,237",
                            ConversionFrom = "Meters per second",
                            ConversionFromValue = 0.0,
                            ConversionName = "Meters per second to Miles per hour",
                            ConversionTo = "Miles per hour",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "MphToMps",
                            CategoryId = 6,
                            ConversionFormula = "divide the speed value by 2,237",
                            ConversionFrom = "Miles per hour",
                            ConversionFromValue = 0.0,
                            ConversionName = "Miles per hour to Meters per second",
                            ConversionTo = "Meters per second",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "MpsToKps",
                            CategoryId = 6,
                            ConversionFormula = "multiply the speed value by 3,6",
                            ConversionFrom = "Meters per second",
                            ConversionFromValue = 0.0,
                            ConversionName = "Meters per second to Kilometers per hour",
                            ConversionTo = "Kilometers per hour",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "KpsToMps",
                            CategoryId = 6,
                            ConversionFormula = "divide the speed value by 3,6",
                            ConversionFrom = "Kilometers per hour",
                            ConversionFromValue = 0.0,
                            ConversionName = "Kilometers per hour to Meters per second",
                            ConversionTo = "Meters per second",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "FahToKel",
                            CategoryId = 1,
                            ConversionFormula = "(32°F − 32) × 5/9 + 273.15 = 273,15K",
                            ConversionFrom = "Fahrenheit",
                            ConversionFromValue = 0.0,
                            ConversionName = "Fahrenheit to Kelvin",
                            ConversionTo = "Kelvin",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "KelToFah",
                            CategoryId = 1,
                            ConversionFormula = "(0K − 273.15) × 9/5 + 32 = -459,7°F",
                            ConversionFrom = "Kelvin",
                            ConversionFromValue = 0.0,
                            ConversionName = "Kelvin to Fahrenheit",
                            ConversionTo = "Fahrenheit",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "DelToFah",
                            CategoryId = 1,
                            ConversionFormula = "[°De] = (373.15 − [K]) × ​3⁄2",
                            ConversionFrom = "Delisle",
                            ConversionFromValue = 0.0,
                            ConversionName = "Delisle to Fahrenheit",
                            ConversionTo = "Fahrenheit",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "FahToDel",
                            CategoryId = 1,
                            ConversionFormula = "[K] = 373.15 − [°De] × ​2⁄3",
                            ConversionFrom = "Fahrenheit",
                            ConversionFromValue = 0.0,
                            ConversionName = "Fahrenheit to Delisle",
                            ConversionTo = "Delisle",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "GraToOun",
                            CategoryId = 2,
                            ConversionFormula = "divide the mass value by 28,35",
                            ConversionFrom = "Grams",
                            ConversionFromValue = 0.0,
                            ConversionName = "Grams to Ounces",
                            ConversionTo = "Ounces",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "OunToGra",
                            CategoryId = 2,
                            ConversionFormula = "multiply the mass value by 28,35",
                            ConversionFrom = "Ounces",
                            ConversionFromValue = 0.0,
                            ConversionName = "Ounces to Grams",
                            ConversionTo = "Grams",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "DayToHou",
                            CategoryId = 7,
                            ConversionFormula = "multiply the time value by 24",
                            ConversionFrom = "Day",
                            ConversionFromValue = 0.0,
                            ConversionName = "Day to Hour",
                            ConversionTo = "Hour",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        },
                        new
                        {
                            ConversionId = "HouToDay",
                            CategoryId = 7,
                            ConversionFormula = "divide the mass value by 24",
                            ConversionFrom = "Hour",
                            ConversionFromValue = 0.0,
                            ConversionName = "Hour to Day",
                            ConversionTo = "Day",
                            ConversionToValue = 0.0,
                            isConversionRequest = true
                        });
                });

            modelBuilder.Entity("Convertor.Models.Conversion", b =>
                {
                    b.HasOne("Convertor.Models.Category", "Category")
                        .WithMany("Conversions")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Convertor.Models.Category", b =>
                {
                    b.Navigation("Conversions");
                });
#pragma warning restore 612, 618
        }
    }
}
