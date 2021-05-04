using Convertor.Models;
using System.Collections.Generic;

namespace Convertor.Data
{
    public interface IRepositoryConversion : IRepositoryBase<Conversion>
    {
        public Conversion FindByConversionWithCategory(string _sId);
        public IEnumerable<Conversion> GetAllConversionAsc(string sortBy);
        public IEnumerable<Conversion> GetAllConversionDesc(string sortBy);
    }
}
