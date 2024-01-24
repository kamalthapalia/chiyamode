using System.Collections.Generic;

namespace chiyamode.Repository
{
    public interface IRepository<T>
    {
        T Save(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(int id);
        bool Login(string username, string password);
    }
}
