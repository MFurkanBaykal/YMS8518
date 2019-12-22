using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Interfaces
{
    public interface IBookRepository
    {
        Model.Book Insert(Model.Book book);
        Model.Book Update(Model.Book book);
        void Delete(int id);
        List<Model.Book> List();
        Model.Book Get(int id);
    }
}
