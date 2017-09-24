using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CampusFleaMarket.FactoryDal
{
    public class FactoryDalContext
    {

        /// <summary>
        ///单例： 获取线程内唯一的DAL层上下文对象
        /// </summary>
        /// <returns></returns>
        public static DalContext GetCurrentDalContext()
        {
            DalContext dc = CallContext.GetData("DalContext") as DalContext;
            if (dc == null)
            {
                dc = new DalContext();
                CallContext.SetData("DalContext",dc);
            }
            return dc;
        }
    }
}
