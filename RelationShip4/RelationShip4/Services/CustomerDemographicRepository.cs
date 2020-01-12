using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Services
{
    public class CustomerDemographicRepository : Repository<Models.CustomerDemographic>, Interfaces.ICustomerDemographicRepository
    {
        private readonly DataContext _dataContext;
        public CustomerDemographicRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
