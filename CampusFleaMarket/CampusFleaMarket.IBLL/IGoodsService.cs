using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusFleaMarket.IBLL
{
    using Model;
    public interface IGoodsService:IBaseService<Goods>
    {

        IEnumerable<CategoryOfGoods> GetCategoryOfGoods { get; }

        IEnumerable<Users> GetUsers { get; }
    
    }
}
