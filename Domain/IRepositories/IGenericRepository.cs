using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetByID(int id);
        T GetByName(string name);
        T GetLastID();
        T Insert(T entity);
        T Update(T entity);
        void Delete(int id);
        void DeleteAll();
    }
}
