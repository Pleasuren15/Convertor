using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Convertor.Data
{
    public class CRepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AppDbContext _appDbContext;
        public CRepositoryBase(AppDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext;
        }

        public void Create(T _entity)
        {
            _appDbContext.Set<T>().Add(_entity);
            Save();
        }

        public void Delete(T _entity)
        {
            _appDbContext.Set<T>().Remove(_entity);
            Save();
        }

        public IEnumerable<T> FindAll()
        {
            return _appDbContext.Set<T>();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> condition)
        {
            return _appDbContext.Set<T>().Where(condition);
        }

        public T FindById(int Id)
        {
            return _appDbContext.Set<T>().Find(Id);
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }

        public void Update(T _entity)
        {
            _appDbContext.Set<T>().Update(_entity);
            Save();
        }
    }
}
