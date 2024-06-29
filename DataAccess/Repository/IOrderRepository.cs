using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        void AddOrder(OrderObject order);
        void DeleteOrder(int id);
        OrderObject GetOrder(int id);
        IEnumerable<OrderObject> GetAllOrder();
        void UpdateOrder(OrderObject order);
    }
}