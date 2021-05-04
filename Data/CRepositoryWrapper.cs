namespace Convertor.Data
{
    public class CRepositoryWrapper : IRepositoryWrapper
    {
        CRepositoryCategory _Categories;
        CRepositoryConversion _Conversions;
        public AppDbContext _appDbContext { get; }

        public CRepositoryWrapper(AppDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext;
        }

        public IRepositoryCategory _categories 
        {
            get
            {
                if (_Categories == null)
                    _Categories = new CRepositoryCategory(_appDbContext);
                return _Categories;
            }
        }

        public IRepositoryConversion _conversions
        {
            get
            {
                if (_Conversions == null)
                    _Conversions = new CRepositoryConversion(_appDbContext);
                return _Conversions;
            }
        }
    }
}
