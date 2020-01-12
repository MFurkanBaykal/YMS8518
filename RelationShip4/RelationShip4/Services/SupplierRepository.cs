using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Services
{
    public class SupplierRepository : Repository<Models.Supplier>, Interfaces.ISupplierRepository
    {
        private readonly DataContext _dataContext;
        public SupplierRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
