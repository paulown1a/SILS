using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
//
namespace SILS.Data
{
    public class EntityData<T> where T:class
    {
        protected SILSEntities CreateContext()
        {
            SILSEntities context = new SILSEntities();
            context.Configuration.ProxyCreationEnabled = false;
            context.Database.Log = (x) => Debug.WriteLine(x);
            return context;
        }

        public List<T> GetAll()
        {
            SILSEntities context = CreateContext();
            return context.Set<T>().ToList();
        }

        public int GetCount()
        {
            SILSEntities context = CreateContext();
            return context.Set<T>().Count();
        }

        public void Insert(T entity)
        {
            
            SILSEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            SILSEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Update(List<T> entities)
        {
            SILSEntities context = CreateContext();
            context.Entry(entities).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            SILSEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
