using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampusFleaMarket.UI.Controllers.BackManager
{
    using FactoryBLL;
    using IBLL;
    public interface IBaseController<T> where T:class
    {
        T services { get; }

        #region 1.0 新增
         //ActionResult Create();
        #endregion
        #region 2.0 修改
         //ActionResult Edit(int id);
        #endregion
        #region 3.0 删除
         ActionResult Delete(int id);
        #endregion
        #region 4.0 详细
         ActionResult Detail(int id);
        #endregion

        //#region 5.0 分页数据获取
        // ActionResult GetUsersByFenYe(int currentPage, int dataCount);
        //#endregion
    }
}