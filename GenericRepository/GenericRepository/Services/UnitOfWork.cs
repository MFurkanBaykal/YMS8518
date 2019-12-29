using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepository.Interfaces;

namespace GenericRepository.Services
{
    public class UnitOfWork : Interfaces.IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            UserRepository = new Services.UserRepository(_dataContext);
        }
        public IUserRepository UserRepository { get; set; }
        public IBookRepository BookRepository { get; set; }
        public IPetRepository PetRepository { get; set; }

        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
