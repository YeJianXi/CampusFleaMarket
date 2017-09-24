using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampusFleaMarket.UI.Controllers.BackManager
{
    using Model;
    using IBLL;
    using FactoryBLL;
    public class GoodManagerController : Controller,IBaseController<IGoodsService>
    {
        //
        // GET: /GoodManager/

        public IGoodsService services
        {

            get { return FactoryService.GetCurrentBLLContext().GoodsService; }
        }
        public ActionResult Index()
        {
            ViewData.Model = services.GetAllEntity();
            return View();
        }
        #region 1.0 新增二手物品
        [HttpGet]
        public ActionResult Create()
        {

            ViewBag.G_Category = new SelectList(services.GetCategoryOfGoods, "C_ID", "C_Name");
            ViewBag.G_User = new SelectList(services.GetUsers, "U_ID", "U_Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Goods good)
        {
            services.AddEntity(good);
            return RedirectToAction("Index");
        
        }
        #endregion
        #region 2.0 修改二手物品信息
        public ActionResult Edit(int id)
        {
            return null;
        }
        #endregion

        #region 3.0 删除二手物品信息
        public ActionResult Delete(int id)
        {
            Goods G = services.GetEntityByLambada(s=>s.G_ID == id);
            services.DeleteEntity(G);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="select"></param>
        /// <returns></returns>
        public ActionResult AllDelete(string[] select)
        {
            services.DeleteEntitys(select);
            return RedirectToAction("Index");
        }

        #endregion


        #region 4.0 二手物品详细信息
        public ActionResult Detail(int id)
        {

            return null;
        }
        #endregion




        public ActionResult GetUsersByFenYe(int currentPage, int dataCount)
        {
            throw new NotImplementedException();
        }
    }
}
