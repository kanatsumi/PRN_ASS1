using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BaseDAO <T> where T : class
    {
        private readonly SaleDbContext _saleDbContext;
        public BaseDAO(SaleDbContext saleDbContext)
        {
            _saleDbContext = new SaleDbContext();
        }
        public void Add(T entity)
        {
            _saleDbContext.Set<T>().Add(entity);
            _saleDbContext.SaveChanges();
        }
        public void Update(T entity)
        {
            _saleDbContext.Set<T>().Update(entity);
            _saleDbContext.SaveChanges();
        }
        public void Delete(T entity)
        {
            _saleDbContext.Set<T>().Remove(entity);
            _saleDbContext.SaveChanges();
        }
        public List<T> GetAll()
        {
            return _saleDbContext.Set<T>().ToList();
        }
        public IQueryable<T> GetQueryAble()
        {
            return _saleDbContext.Set<T>().AsQueryable();
        }
    }
}
