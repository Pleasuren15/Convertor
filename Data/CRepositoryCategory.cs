using Convertor.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Convertor.Data
{
    public class CRepositoryCategory : CRepositoryBase<Category>, IRepositoryCategory
    {
        public CRepositoryCategory(AppDbContext appDbContext) : base(appDbContext) { }

        public Category FindByCategoryWithConversions(string _sCategoryName)
        {
            return _appDbContext.Categories.Include(c => c.Conversions.Where(_c => !_c.isConversionRequest))
                                    .FirstOrDefault(c => c.CategoryName == _sCategoryName);
        }
    }
}
