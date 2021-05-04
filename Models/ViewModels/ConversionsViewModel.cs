using System.Collections.Generic;

namespace Convertor.Models.ViewModels
{
    public class ConversionsViewModel
    {
        public PagingInfo pagingInfo { get; set; }
        public IEnumerable<Conversion> conversions { get; set; }
    }
}
