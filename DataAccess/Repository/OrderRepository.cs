using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDAO orderDAO;
        private readonly SaleDbContext _context;

        public OrderRepository()
        {
            _context = new SaleDbContext();
            orderDAO = new OrderDAO(_context);
        }

        public void AddOrder(OrderObject order)
        {
            orderDAO.Add(order);
        }

        public void DeleteOrder(int id)
        {
            orderDAO.Delete(GetOrder(id));
        }

        public OrderObject GetOrder(int id)
        {
            return orderDAO.GetQueryAble().FirstOrDefault(p => p.OrderId == id);
        }

        public IEnumerable<OrderObject> GetAllOrder()
        {
            return orderDAO.GetAll();
        }

        public void UpdateOrder(OrderObject order)
        {
            orderDAO.Update(order);
        }
    }
}
