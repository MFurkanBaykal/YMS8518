using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Services
{
    public class TerritoryRepository: Repository<Models.Territory>, Interfaces.ITerritoryRepository
    {
        private readonly DataContext _dataContext;
        public TerritoryRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
