using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDAO productDAO;
        private readonly SaleDbContext _context;

        public ProductRepository()
        {
            _context = new SaleDbContext();
            productDAO = new ProductDAO(_context);
        }

        public void AddProduct(ProductObject product)
        {
            productDAO.Add(product);
        }

        public void DeleteProduct(int id)
        {
            productDAO.Delete(GetProduct(id));
        }

        public ProductObject GetProduct(int id)
        {
            return productDAO.GetQueryAble().FirstOrDefault(p => p.ProductId == id);
        }

        public IEnumerable<ProductObject> GetAllProduct()
        {
            return productDAO.GetAll();
        }

        public void UpdateProduct(ProductObject product)
        {
            productDAO.Update(product);
        }
    }
}
