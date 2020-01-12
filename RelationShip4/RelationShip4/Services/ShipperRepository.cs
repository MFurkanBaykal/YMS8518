using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Services
{
    public class ShipperRepository : Repository<Models.Shipper>, Interfaces.IShipperRepository
    {
        private readonly DataContext _dataContext;
        public ShipperRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
