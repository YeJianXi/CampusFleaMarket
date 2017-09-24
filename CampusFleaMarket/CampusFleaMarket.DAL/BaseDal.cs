using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampusFleaMarket.IDAL;

namespace CampusFleaMarket.DAL
{
    using CampusFleaMarket.Model;
    using System.Data.Entity;
    using System.Data;
    
    public class BaseDal<T> where T:class,new()
    {

        DbContext db = DbContextFactory.GetEF_DbContext();  

        public bool AddEntity(T entity)
        {
            db.Set<T>().Add(entity);
            return false;
        }

        public bool DeleteEntity(T entity)
        {
            db.Set<T>().Remove(entity);
            //db.Entry(entity).State = EntityState.Deleted;
            return true;
        }

        public bool UpdateEntity(T entity)
        {
            //db.Set<T>().Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            return false;
        }

        public List<T> GetAllEntity(Func<T, object> lambada )
        {
            if (lambada == null)
            {
                return db.Set<T>().ToList();
            }
            else
            {
                return db.Set<T>().OrderBy(lambada).ToList();
            }
        }

     public    T GetEntityByLambada(Func<T, bool> lambada)
        {
            return db.Set<T>().FirstOrDefault(lambada);
        }
        
        



    }
}
