using Convertor.Models;

namespace Convertor.Data
{
    public interface IRepositoryCategory : IRepositoryBase<Category>
    {
        public Category FindByCategoryWithConversions(string _sCategoryName);
    }
}
