using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Services
{
    public class EmployeeTerritoryRepository : Repository<Models.EmployeeTerritory>, Interfaces.IEmployeeTerritoryRepository
    {
        private readonly DataContext _dataContext;
        public EmployeeTerritoryRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

    }
}
