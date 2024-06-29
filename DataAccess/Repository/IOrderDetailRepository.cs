using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        void AddOrderDetail(OrderDetailObject orderDetail);
        void DeleteOrderDetail(int id);
        OrderDetailObject GetOrderDetail(int id);
        IEnumerable<OrderDetailObject> GetAllOrderDetail();
        void UpdateOrderDetail(OrderDetailObject orderDetail);
    }
}