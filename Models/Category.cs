using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Convertor.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryUrl { get; set; }

        public ICollection<Conversion> Conversions { get; set; }
    }
}
