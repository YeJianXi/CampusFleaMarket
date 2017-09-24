using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CampusFleaMarket.FactoryBLL
{
    public  class FactoryService
    {

        /// <summary>
        /// 单例：获取线程中唯一的BLL上下文对象
        /// </summary>
        /// <returns></returns>
        public static BLLContext GetCurrentBLLContext()
        {
            BLLContext bc = CallContext.GetData("BLLContext") as BLLContext;
            if (bc == null)
            {
                bc = new BLLContext();
                CallContext.SetData("BLLContext", bc);
            }
            return bc;
        }
    }
}
