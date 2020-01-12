using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Services
{
    public class CustomerCustomerDemoRepository : Repository<Models.CustomerCustomerDemo>, Interfaces.ICustomerCustomerDemoRepository
    {
        private readonly DataContext _dataContext;
        public CustomerCustomerDemoRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
    
}
