using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Convertor.Models
{
    public class Conversion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("Id")]
        public string ConversionId { get; set; }

        [Required]
        [DisplayName("Name")]
        public string ConversionName { get; set; }

        [Required]
        [DisplayName("From")]
        public string ConversionFrom { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double ConversionFromValue { get; set; }

        [Required]
        [DisplayName("To")]
        public string ConversionTo { get; set; }
        
        [DataType(DataType.Currency)]
        public double ConversionToValue { get; set; }

        [Required]
        [DisplayName("Formula")]
        public string ConversionFormula { get; set; }
        public bool isConversionRequest { get; set; } = false;

        [Required]
        [DisplayName("Category Id")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
