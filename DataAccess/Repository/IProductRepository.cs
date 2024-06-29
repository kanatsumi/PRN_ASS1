using BusinessObject;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        void AddProduct(ProductObject product);
        void DeleteProduct(int id);
        ProductObject GetProduct(int id);
        IEnumerable<ProductObject> GetAllProduct();
        void UpdateProduct(ProductObject product);
    }
}