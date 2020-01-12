using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Services
{
    public class OrderDetailRepository : Repository<Models.OrderDetail>, Interfaces.IOrderDetailRepository
    {
        private readonly DataContext _dataContext;
        public OrderDetailRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
