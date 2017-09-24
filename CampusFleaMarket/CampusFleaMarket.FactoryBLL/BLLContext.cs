using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CampusFleaMarket.FactoryBLL
{

    using IBLL;
    using BLL;
    public class BLLContext
    {

        /// <summary>
        /// 获取UserService对象，操作Users表的业务逻辑
        /// </summary>
        public IUserService UserService { get { return new UsersService(); } }

        public IGoodsService GoodsService { get { return new GoodsService(); } }

        public IGoodsCommentService GoodsCommentService { get { return new GoodsCommentService(); } }

        public ICategoryOfGoodsService CategoryOfGoodsService { get { return new CategoryOfGoodsService(); } }
    
    
    
    
    
    }
}
