using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CampusFleaMarket.Model
{

    /// <summary>
    /// 单例：获取线程内唯一一个EF上下文对象
    /// </summary>
    public class DbContextFactory
    {
        
        public static DbContext GetEF_DbContext()
        {
            
            DbContext db = CallContext.GetData("DbContext") as DbContext;
            if (db == null)
            {
                db = new CampusFleaMarketDBEntities();
                CallContext.SetData("DbContext", db);
            }
            
            return db;
        }
    }
}
