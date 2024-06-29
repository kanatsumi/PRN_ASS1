using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO : BaseDAO<OrderObject>
    {
        private readonly SaleDbContext _saleDbContext;
        public OrderDAO(SaleDbContext saleDbContext) : base(saleDbContext)
        {
            if(saleDbContext == null)
            {
                _saleDbContext = new SaleDbContext();
            } else
            {
                _saleDbContext = saleDbContext;
            }
        }
    }
}
