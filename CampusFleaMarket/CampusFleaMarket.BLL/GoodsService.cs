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
    using System.Data.Entity;
   public  class GoodsService:BaseService<Goods>,IGoodsService
    {
       public override IDAL.IBaseDal<Goods> CurrentDal
       {
           get { return FactoryDalContext.GetCurrentDalContext().GoodsDal; }
       }

       /// <summary>
       /// 批量删除二手物品的实体
       /// </summary>
       /// <param name="select"></param>
       /// <returns></returns>
       public override bool DeleteEntitys(string[] select)
       {
           foreach (string item in select)
           {
               Goods g = CurrentDal.GetEntityByLambada(m => m.G_ID == int.Parse(item));
               CurrentDal.DeleteEntity(g);
           }

           return DC.SaveChange() >= select.Length;
       }

       /// <summary>
       /// 获取CategoryOfGoods集合
       /// </summary>
       public IEnumerable<CategoryOfGoods> GetCategoryOfGoods
       {
           get { return DbContextFactory.GetEF_DbContext().Set<CategoryOfGoods>(); }
       }

       /// <summary>
       /// 获取Users集合
       /// </summary>
       public IEnumerable<Users> GetUsers
       {
           get { return DbContextFactory.GetEF_DbContext().Set<Users>(); }
       }




       
    }
}
