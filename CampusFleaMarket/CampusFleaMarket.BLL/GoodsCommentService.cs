using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusFleaMarket.BLL
{
    using Model;
    using IBLL;
    using FactoryDal;
    public class GoodsCommentService:BaseService<GoodsComments>,IGoodsCommentService
    {
        public override IDAL.IBaseDal<GoodsComments> CurrentDal
        {
            get { return FactoryDalContext.GetCurrentDalContext().GoodsCommentDal; }
        }
    }
}
