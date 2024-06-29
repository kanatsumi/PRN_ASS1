using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO : BaseDAO<OrderDetailObject>
    {
        private readonly SaleDbContext _saleDbContext;
        public OrderDetailDAO(SaleDbContext saleDbContext) : base(saleDbContext)
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
