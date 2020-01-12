using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Services
{
    public class OrderRepository : Repository<Models.Order>, Interfaces.IOrderRepository
    {
        private readonly DataContext _dataContext;
        public OrderRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
