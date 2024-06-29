using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly OrderDetailDAO orderDAO;
        private readonly SaleDbContext _context;

        public OrderDetailRepository()
        {
            _context = new SaleDbContext();
            orderDAO = new OrderDetailDAO(_context);
        }

        public void AddOrderDetail(OrderDetailObject orderDetail)
        {
            orderDAO.Add(orderDetail);
        }

        public void DeleteOrderDetail(int id)
        {
            orderDAO.Delete(GetOrderDetail(id));
        }

        public OrderDetailObject GetOrderDetail(int id)
        {
            return orderDAO.GetQueryAble().FirstOrDefault(p => p.OrderId == id);
        }

        public IEnumerable<OrderDetailObject> GetAllOrderDetail()
        {
            return orderDAO.GetAll();
        }

        public void UpdateOrderDetail(OrderDetailObject orderDetail)
        {
            orderDAO.Update(orderDetail);
        }
    }
}
