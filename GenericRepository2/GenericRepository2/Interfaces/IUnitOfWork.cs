using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository2.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository StudentRepository { get; set; }
        int Complete();
    }
}
