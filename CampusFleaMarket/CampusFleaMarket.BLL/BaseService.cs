using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusFleaMarket.BLL
{
    using FactoryDal;
    using IDAL;
     public abstract  class BaseService<T> where T:class,new()
    {
         public DalContext DC { get{return FactoryDalContext.GetCurrentDalContext();}}

         public abstract IBaseDal<T> CurrentDal { get; }
        /// 添加一个T类型的实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
         public bool AddEntity(T entity)
         {
             CurrentDal.AddEntity(entity);

             return DC.SaveChange() > 0;
         }

         public bool DeleteEntity(T entity)
         {
             CurrentDal.DeleteEntity(entity);
             return DC.SaveChange() > 0;
         }

         public bool UpdateEntity(T entity)
         {
             CurrentDal.UpdateEntity(entity);
             return DC.SaveChange() > 0;
         }

         public List<T> GetAllEntity(Func<T, object> lambada = null)
         {

             return CurrentDal.GetAllEntity(lambada);
         }

        /// <summary>
        /// 通过lambada表达式拿到一个实体
        /// </summary>
        /// <param name="lambada"></param>
        /// <returns></returns>
         public T GetEntityByLambada(Func<T, bool> lambada)
         {
          return   CurrentDal.GetEntityByLambada(lambada);
         }


         /// <summary>
         /// 删除选中的记录
         /// </summary>
         /// <param name="select"></param>
         /// <returns></returns>
         public virtual  bool  DeleteEntitys(string[] select)
         {
             return false;
         }
    }
}
