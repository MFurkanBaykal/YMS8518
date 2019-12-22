using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi2.Interfaces
{
    public interface IBookRepository
    {
        Models.Book Insert(Models.Book book);
        Models.Book Update(Models.Book book);
        void Delete(int id);
        List<Models.Book> List();
        Models.Book Get(int id);
    }
}
