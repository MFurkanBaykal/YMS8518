using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepository2.Interfaces;

namespace GenericRepository2.Services
{
    public class UnitOfWork : Interfaces.IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            StudentRepository = new Services.StudentRepository(_dataContext);
        }
        public IStudentRepository StudentRepository { get; set; }

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
