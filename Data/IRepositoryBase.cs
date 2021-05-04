using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Convertor.Data
{
    public interface IRepositoryBase<T>
    {
        public void Create(T _entity);
        public void Update(T _entity);
        public void Delete(T _entity);
        public void Save();
        public IEnumerable<T> FindAll();
        public T FindById(int Id);
        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> condition);
    }
}
