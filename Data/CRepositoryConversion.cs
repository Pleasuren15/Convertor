using Convertor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Convertor.Data
{
    public class CRepositoryConversion : CRepositoryBase<Conversion>, IRepositoryConversion
    {
        public CRepositoryConversion(AppDbContext appDbContext) : base(appDbContext) { }

        public Conversion FindByConversionWithCategory(string Id)
        {
            return _appDbContext.Conversions.Include(c => c.Category)
                            .FirstOrDefault(f => f.ConversionId == Id);
        }

        public IEnumerable<Conversion> GetAllConversionAsc(string sortBy)
        {
            return _appDbContext.Conversions.Where(e => e.isConversionRequest).OrderBy(e => EF.Property<object>(e, sortBy));
        }

        public IEnumerable<Conversion> GetAllConversionDesc(string sortBy)
        {
            return _appDbContext.Conversions.Where(e => e.isConversionRequest).OrderByDescending(e => EF.Property<object>(e, sortBy));
        }
    }
}
