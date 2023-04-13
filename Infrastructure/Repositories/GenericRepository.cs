using DataAccessLayer.Infrastructure.DataBase;
using Microsoft.EntityFrameworkCore;
using SharedLayer.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DBHelper db;
        public GenericRepository(DBHelper _db)
        {
            db = _db;
        }
        public void Delete(int id)
        {
           
            db.Set<T>().Remove(GetByID(id));
            db.SaveChanges();
        }
        public void DeleteAll()
        {
            db.Set<T>().RemoveRange(GetAll());
            db.SaveChanges();
        }
        public IQueryable<T> GetAll()
        {
            //db.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
            return db.Set<T>().AsQueryable();
        }
        public T GetByID(int id)
        {
            return db.Set<T>().Find(id);
        }
        public T GetByName(string name)
        {
            return db.Set<T>().Find(name);
        }
        public T GetLastID()
        {
            return db.Set<T>().Max();
        }
        public T Insert(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
            return entity;
        }
        public T Update(T entity)
        {
            db.Set<T>().Attach(entity);
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //db.Set<T>().Update(entity);
            db.SaveChanges();
            return entity;
        }
    }
}
