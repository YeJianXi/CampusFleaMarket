using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusFleaMarket.FactoryDal
{
    using CampusFleaMarket.Model;
    using CampusFleaMarket.DAL;
    using CampusFleaMarket.IDAL;
    /// <summary>
    /// DAL层的上下文类
    /// </summary>
    public class DalContext
    {

        /// <summary>
        /// 保存EF的修改，映射到数据库中去
        /// </summary>
        /// <returns>执行结果</returns>
        public int SaveChange()
        {
            return DbContextFactory.GetEF_DbContext().SaveChanges();
        }

        /// <summary>
        /// 获取UserDal对象，操作Users表
        /// </summary>
        public IUserDal UsersDal { get { return new UserDal(); } }

        /// <summary>
        /// 获取GoodsDal对象，操作Goods表
        /// </summary>
        public IGoodsDal GoodsDal { get { return new GoodsDal(); } }

        public IGoodsCommentDal GoodsCommentDal { get { return new GoodsCommentDal(); } }

        public ICategoryOfGoodsDal CategoryOfGoodsDal { get { return new CategoryOfGoodsDal(); } }
    
    
    }
}
