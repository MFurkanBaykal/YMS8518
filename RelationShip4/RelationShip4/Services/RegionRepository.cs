using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Services
{
    public class RegionRepository : Repository<Models.Region>, Interfaces.IRegionRepository
    {
        private readonly DataContext _dataContext;
        public RegionRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
