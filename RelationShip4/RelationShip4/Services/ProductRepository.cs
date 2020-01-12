using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Services
{
    public class ProductRepository : Repository<Models.Product>, Interfaces.IProductRepository
    {
        private readonly DataContext _dataContext;
        public ProductRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
