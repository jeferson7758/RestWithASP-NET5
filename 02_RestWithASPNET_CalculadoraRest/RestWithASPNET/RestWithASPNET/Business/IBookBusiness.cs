using RestWithASPNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book Update(Book book);
        Book FindById(long id);
        void Delete(long id);
        List<Book> FindAll();
    }
}
