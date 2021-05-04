using Convertor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Convertor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Conversion> Conversions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Catogories Seeded Data
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Temperature",
                    CategoryDescription = "Celsius, Fahrenheit, Kelvin & more units",
                    CategoryUrl = "https://img.icons8.com/nolan/64/temperature.png"
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Weight",
                    CategoryDescription = "Pounds, Kilograms, Ounces, Stone & more units",
                    CategoryUrl = "https://img.icons8.com/nolan/64/weight-kg.png"
                },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Length",
                    CategoryDescription = "Miles, Kilometres, Metres, Feet, Inches, Centimetres & more units",
                    CategoryUrl = "https://img.icons8.com/nolan/64/ruler.png"
                },
                new Category()
                {
                    CategoryId = 4,
                    CategoryName = "Area",
                    CategoryDescription = "Hectares, Square Feet, Square Metres, Acres & more units",
                    CategoryUrl = "https://img.icons8.com/nolan/64/pi.png"
                },
                new Category()
                {
                    CategoryId = 5,
                    CategoryName = "Volume",
                    CategoryDescription = "US Gallos, US Pints, Litres, Milliliters, UK Pints & more units",
                    CategoryUrl = "https://img.icons8.com/nolan/64/scales.png"
                },
                new Category()
                {
                    CategoryId = 6,
                    CategoryName = "Speed",
                    CategoryDescription = "Kilometres per hour, Miles per hour, Knots & more units",
                    CategoryUrl = "https://img.icons8.com/nolan/64/speed.png"
                },
                new Category()
                {
                    CategoryId = 7,
                    CategoryName = "Time",
                    CategoryDescription = "Seconds, Minutes, Hours & more units",
                    CategoryUrl = "https://img.icons8.com/nolan/64/time.png"
                },
                new Category()
                {
                    CategoryId = 8,
                    CategoryName = "Angle",
                    CategoryDescription = "Radians, Degrees & more units",
                    CategoryUrl = "https://img.icons8.com/nolan/64/trigonometry.png"
                });
            #endregion

            #region Conversion Seeded Data
            modelBuilder.Entity<Conversion>().HasData(
                new Conversion()
                { ConversionId = "CelToFah", ConversionName = "Celsius to Fahrenheit", ConversionFormula = "(0°C × 9/5) + 32 = 32°F", ConversionFrom = "Celsius", ConversionTo = "Fahrenheit", CategoryId = 1 },
                new Conversion() { ConversionId = "FahToCel", ConversionName = "Fahrenheit to Celsius", ConversionFormula = "(32°F − 32) × 5/9 = 0°C", ConversionFrom = "Fahrenheit", ConversionTo = "Celsius", CategoryId = 1 }, new Conversion()
                { ConversionId = "CelToKel", ConversionName = "Celsius to Kelvin", ConversionFormula = "0°C + 273.15 = 273,15K", ConversionFrom = "Celsius", ConversionTo = "Kelvin", CategoryId = 1 }, new Conversion()
                { ConversionId = "KelToCel", ConversionName = "Kelvin to Celsius", ConversionFormula = "0K − 273.15 = -273,1°C", ConversionFrom = "Kelvin", ConversionTo = "Celsius", CategoryId = 1 }, new Conversion()
                { ConversionId = "DegToRad", ConversionName = "Degrees to Radians", ConversionFormula = "1Deg × π/180 = 0,01745Rad", ConversionFrom = "Degrees", ConversionTo = "Radians", CategoryId = 8 },
                new Conversion()
                { ConversionId = "RadToDeg", ConversionName = "Radians to Degrees", ConversionFormula = "1Rad × 180/π = 57,296Deg", ConversionFrom = "Radians", ConversionTo = "Degrees", CategoryId = 8 }, new Conversion()
                { ConversionId = "SquToAcr", ConversionName = "Square Feet to Acres", ConversionFormula = "divide the area value by 43560", ConversionFrom = "Square Feet", ConversionTo = "Acres", CategoryId = 4 }, new Conversion()
                { ConversionId = "AcrToSqu", ConversionName = "Acres to Square Feet", ConversionFormula = "multiply the area value by 43560", ConversionFrom = "Acres", ConversionTo = "Square Feet", CategoryId = 4 }, new Conversion()
                { ConversionId = "MetToFee", ConversionName = "Meters to Feet", ConversionFormula = "multiply the length value by 3,281", ConversionFrom = "Meters", ConversionTo = "Feet", CategoryId = 3 }, new Conversion()
                { ConversionId = "FeeToMet", ConversionName = "Feet to Meters", ConversionFormula = "divide the length value by 3,281", ConversionFrom = "Feet", ConversionTo = "Meters", CategoryId = 3 },
                new Conversion()
                { ConversionId = "IncToCen", ConversionName = "Inches to Centimeters", ConversionFormula = "multiply the length value by 2,54", ConversionFrom = "Inches", ConversionTo = "Centimeters", CategoryId = 3 }, new Conversion()
                { ConversionId = "CenToInc", ConversionName = "Centimeters to Inches", ConversionFormula = "divide the length value by 2,54", ConversionFrom = "Centimeters", ConversionTo = "Inches", CategoryId = 3 }, new Conversion()
                { ConversionId = "MilToInc", ConversionName = "Millimeters to Inches", ConversionFormula = "divide the length value by 25,4", ConversionFrom = "Millimeters", ConversionTo = "Inches", CategoryId = 3 }, new Conversion()
                { ConversionId = "IncToMil", ConversionName = "Inches to Millimeters", ConversionFormula = "multiply the length value by 25,4", ConversionFrom = "Inches", ConversionTo = "Millimeters", CategoryId = 3 }, new Conversion()
                { ConversionId = "IncToFee", ConversionName = "Inches to Feet", ConversionFormula = "divide the length value by 12", ConversionFrom = "Inches", ConversionTo = "Feet", CategoryId = 3 },
                new Conversion()
                { ConversionId = "FeeToInc", ConversionName = "Feet to Inches", ConversionFormula = "multiply the length value by 12", ConversionFrom = "Feet", ConversionTo = "Inches", CategoryId = 3 }, new Conversion()
                { ConversionId = "MilToKil", ConversionName = "Miles to Kilometers", ConversionFormula = "multiply the speed value by 1,609", ConversionFrom = "Miles", ConversionTo = "Kilometers", CategoryId = 3 }, new Conversion()
                { ConversionId = "KilToMil", ConversionName = "Kilometers to Miles", ConversionFormula = "divide the speed value by 1,609", ConversionFrom = "Kilometers", ConversionTo = "Miles", CategoryId = 3 }, new Conversion()
                { ConversionId = "SecToMin", ConversionName = "Second to Minute", ConversionFormula = "divide the time value by 60", ConversionFrom = "Second", ConversionTo = "Minute", CategoryId = 7 }, new Conversion()
                { ConversionId = "MinToSec", ConversionName = "Minute to Second", ConversionFormula = "multiply the time value by 60", ConversionFrom = "Minute", ConversionTo = "Second", CategoryId = 7 },
                new Conversion()
                { ConversionId = "SecToHou", ConversionName = "Second to Hour", ConversionFormula = "divide the time value by 3600", ConversionFrom = "Second", ConversionTo = "Hour", CategoryId = 7 }, new Conversion() { ConversionId = "HouToSec", ConversionName = "Hour to Second", ConversionFormula = "multiply the time value by 3600", ConversionFrom = "Hour", ConversionTo = "Second", CategoryId = 7 }, new Conversion()
                { ConversionId = "MinToHou", ConversionName = "Minute to Hour", ConversionFormula = "divide the time value by 60", ConversionFrom = "Minute", ConversionTo = "Hour", CategoryId = 7 }, new Conversion()
                { ConversionId = "HouToMin", ConversionName = "Hour to Min", ConversionFormula = "multiply the time value by 60", ConversionFrom = "Hour", ConversionTo = "Minute", CategoryId = 7 },
                /*HERE*//*HERE*//*HERE*//*HERE*//*HERE*//*HERE*//*HERE*//*HERE*//*HERE*//*HERE*//*HERE*//*HERE*//*HERE*/
                new Conversion()
                { ConversionId = "GraToRad", ConversionName = "Gradians to Radians", ConversionFormula = "1Grad × π/200 = 0,01571Rad", ConversionFrom = "Gradians", ConversionTo = "Radians", CategoryId = 8, isConversionRequest = true },
                new Conversion()
                { ConversionId = "RadToGra", ConversionName = "Radians to Gradians", ConversionFormula = "1Rad × 200/π = 63,662Grad", ConversionFrom = "Radians", ConversionTo = "Gradians", CategoryId = 8, isConversionRequest = true },
                new Conversion()
                { ConversionId = "HecToAcr", ConversionName = "Hectares to Acres", ConversionFormula = "multiply the area value by 2,471", ConversionFrom = "Hectares", ConversionTo = "Acres", CategoryId = 4, isConversionRequest = true },
                new Conversion()
                { ConversionId = "AcrToHec", ConversionName = "Acres to Hectares", ConversionFormula = "divide the area value by 2,471", ConversionFrom = "Acres", ConversionTo = "Hectares", CategoryId = 4, isConversionRequest = true },
                new Conversion()
                { ConversionId = "HecToSqu", ConversionName = "Hectares to Square Feet", ConversionFormula = "multiply the area value by 107639", ConversionFrom = "Hectares", ConversionTo = "Square Feet", CategoryId = 4, isConversionRequest = true },
                new Conversion()
                { ConversionId = "SquToHec", ConversionName = "Square Feet to Hectares", ConversionFormula = "divide the area value by 107639", ConversionFrom = "Square Feet", ConversionTo = "Hectares", CategoryId = 4, isConversionRequest = true },
                new Conversion()
                { ConversionId = "KphToMph", ConversionName = "Kilometers per hour to Miles per hour", ConversionFormula = "divide the speed value by 1,609", ConversionFrom = "Kilometers per hour", ConversionTo = "Miles per hour", CategoryId = 6, isConversionRequest = true },
                new Conversion()
                { ConversionId = "MphToKph", ConversionName = "Miles per hour to Kilometers per hour", ConversionFormula = "multiply the speed value by 1,609", ConversionFrom = "Miles per hour", ConversionTo = "Kilometers per hour", CategoryId = 6, isConversionRequest = true },
                new Conversion()
                { ConversionId = "MpsToMph", ConversionName = "Meters per second to Miles per hour", ConversionFormula = "multiply the speed value by 2,237", ConversionFrom = "Meters per second", ConversionTo = "Miles per hour", CategoryId = 6, isConversionRequest = true },
                new Conversion()
                { ConversionId = "MphToMps", ConversionName = "Miles per hour to Meters per second", ConversionFormula = "divide the speed value by 2,237", ConversionFrom = "Miles per hour", ConversionTo = "Meters per second", CategoryId = 6, isConversionRequest = true },
                new Conversion()
                { ConversionId = "MpsToKps", ConversionName = "Meters per second to Kilometers per hour", ConversionFormula = "multiply the speed value by 3,6", ConversionFrom = "Meters per second", ConversionTo = "Kilometers per hour", CategoryId = 6, isConversionRequest = true },
                new Conversion()
                { ConversionId = "KpsToMps", ConversionName = "Kilometers per hour to Meters per second", ConversionFormula = "divide the speed value by 3,6", ConversionFrom = "Kilometers per hour", ConversionTo = "Meters per second", CategoryId = 6, isConversionRequest = true },
                new Conversion()
                { ConversionId = "FahToKel", ConversionName = "Fahrenheit to Kelvin", ConversionFormula = "(32°F − 32) × 5/9 + 273.15 = 273,15K", ConversionFrom = "Fahrenheit", ConversionTo = "Kelvin", CategoryId = 1, isConversionRequest = true },
                new Conversion()
                { ConversionId = "KelToFah", ConversionName = "Kelvin to Fahrenheit", ConversionFormula = "(0K − 273.15) × 9/5 + 32 = -459,7°F", ConversionFrom = "Kelvin", ConversionTo = "Fahrenheit", CategoryId = 1, isConversionRequest = true },

                //Requests
                new Conversion()
                { ConversionId = "DelToFah", ConversionName = "Delisle to Fahrenheit", ConversionFormula = "[°De] = (373.15 − [K]) × ​3⁄2", ConversionFrom = "Delisle", ConversionTo = "Fahrenheit", CategoryId = 1, isConversionRequest = true },
                new Conversion()
                { ConversionId = "FahToDel", ConversionName = "Fahrenheit to Delisle", ConversionFormula = "[K] = 373.15 − [°De] × ​2⁄3", ConversionFrom = "Fahrenheit", ConversionTo = "Delisle", CategoryId = 1, isConversionRequest = true },
                new Conversion()
                { ConversionId = "GraToOun", ConversionName = "Grams to Ounces", ConversionFormula = "divide the mass value by 28,35", ConversionFrom = "Grams", ConversionTo = "Ounces", CategoryId = 2, isConversionRequest = true },
                new Conversion()
                { ConversionId = "OunToGra", ConversionName = "Ounces to Grams", ConversionFormula = "multiply the mass value by 28,35", ConversionFrom = "Ounces", ConversionTo = "Grams", CategoryId = 2 , isConversionRequest = true },
                new Conversion()
                { ConversionId = "DayToHou", ConversionName = "Day to Hour", ConversionFormula = "multiply the time value by 24", ConversionFrom = "Day", ConversionTo = "Hour", CategoryId = 7 , isConversionRequest = true },
                new Conversion()
                { ConversionId = "HouToDay", ConversionName = "Hour to Day", ConversionFormula = "divide the mass value by 24", ConversionFrom = "Hour", ConversionTo = "Day", CategoryId = 7, isConversionRequest = true });
            #endregion
        }
    }
}
