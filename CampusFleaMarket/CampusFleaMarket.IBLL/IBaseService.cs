using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusFleaMarket.IBLL
{
    public interface IBaseService<T> where T:class,new ()
    {
        /// 添加一个T类型的实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool AddEntity(T entity);

        bool DeleteEntity(T entity);

        bool UpdateEntity(T entity);

        List<T> GetAllEntity(Func<T,object> lambada =null);

        /// <summary>
        /// 通过lambada表达式拿到一个实体
        /// </summary>
        /// <param name="lambada"></param>
        /// <returns></returns>
        T GetEntityByLambada(Func<T, bool> lambada);


        /// <summary>
        /// 批量删除数据
        /// </summary>
        /// <param name="select"></param>
        /// <returns></returns>
        bool DeleteEntitys(string[] select);
        
    }
}
