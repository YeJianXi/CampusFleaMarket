using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampusFleaMarket.UI.Controllers.BackManager
{
    using IBLL;
    using Model;
    using FactoryBLL;
    public class GoodsCommentsController : Controller,IBaseController<IGoodsCommentService>
    {

        public IGoodsCommentService services
        {
            get { return FactoryService.GetCurrentBLLContext().GoodsCommentService; }
        }
        //
        // GET: /GoodsComments/

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        public ActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Detail(int id)
        {
            throw new NotImplementedException();
        }




        public ActionResult GetUsersByFenYe(int currentPage, int dataCount)
        {
            throw new NotImplementedException();
        }
    }
}
