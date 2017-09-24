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
    public class CategoryOfGoodsService:BaseService<CategoryOfGoods>,ICategoryOfGoodsService
    {


        public override IDAL.IBaseDal<CategoryOfGoods> CurrentDal
        {
            get { return FactoryDalContext.GetCurrentDalContext().CategoryOfGoodsDal; }
        }
    }
}
