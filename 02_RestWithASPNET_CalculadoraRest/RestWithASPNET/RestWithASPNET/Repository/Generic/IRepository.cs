using RestWithASPNET.Model;
using RestWithASPNET.Model.Base;
using System.Collections.Generic;

namespace RestWithASPNET.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T Update(T item);
        T FindById(long id);
        void Delete(long id);
        List<T> FindAll();
        bool Exists(long id);


    }
}
