using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusFleaMarket.IDAL
{
    public interface IBaseDal<T> where T:class,new()
    {
        /// <summary>
        /// 添加一个T类型的实体

        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool AddEntity(T entity);

        bool DeleteEntity(T entity);

        bool UpdateEntity(T entity);

        List<T> GetAllEntity(Func<T, object> lambada);

        /// <summary>
        /// 通过lambada表达式拿到一个实体
        /// </summary>
        /// <param name="lambada"></param>
        /// <returns></returns>
        T GetEntityByLambada(Func<T,bool> lambada);
    }
}
