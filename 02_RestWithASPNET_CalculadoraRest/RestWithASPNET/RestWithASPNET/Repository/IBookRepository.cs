using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book Update(Book book);
        Book FindById(long id);
        void Delete(long id);
        List<Book> FindAll();
        bool Exists(long id);
    }
}
