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
    using System.IO;
    public class UserManagerController :Controller
    {
        
        public IUserService services
        {
            get { return FactoryService.GetCurrentBLLContext().UserService; }
        }
        //
        // GET: /UserManager/

        public ActionResult Index(int currentPage=1, int dataCount = 10)
        {
            ViewData.Model = services.GetAllEntity(u => u.U_StuNumber).Skip((currentPage - 1) * dataCount).Take(dataCount);
            ViewBag.total = (services.GetAllEntity().Count+ dataCount)/dataCount;
            return View();
        }

        #region 0.0 新增+Create
       
        [HttpGet]
        /// <summary>
        /// 返回新增用户模态窗口需要的数据
        /// </summary>
        /// <returns></returns>
        public ActionResult PartialCreate()
        {

            ViewBag.U_State = new SelectList(new Models.U_StateDataSource().dataSource, "Id", "U_State");
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Users user)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    
                    //1.0将学生证保存到服务器上
                    if (user.CompusCard != null)
                    {
                        foreach (var item in user.CompusCard)
                        {
                            string CGUID1 = System.Guid.NewGuid().ToString() + ".jpg";
                            string CampuCardFilePath1 = Server.MapPath(string.Format("~/Image/CampusCard/{0}", CGUID1));
                            item.SaveAs(Path.Combine(CampuCardFilePath1));
                            user.U_CompusCard += CGUID1.ToString()+";";
                        }
                    }
                    else {
                        throw new Exception("未上传学生证");
                    }
                    //2.0将头像保存到服务上
                    if (user.Head_Image != null)
                    {
                        string HGUID1 = System.Guid.NewGuid().ToString() + "jpg";
                        string HeadImgFilePath = Server.MapPath(string.Format("~/Image/HeadImage/{0}", HGUID1));
                        user.Head_Image.SaveAs(Path.Combine(HeadImgFilePath));
                        user.U_HeadImage = HGUID1;

                    }
                    else {
                        user.U_HeadImage = "1.jpg";//添加默认头像
                    }
                    services.AddEntity(user);
                }
                catch(Exception ex) {
                    Response.Write("<script>alert('"+ex.Message+"')</script>");
                }
            }
            return RedirectToAction("Index");
        }
        #endregion


        #region  1.0 修改+Edit
        [HttpGet]
        public ActionResult PartialEdit(int id)
        {

            Users user = services.GetEntityByLambada(u => u.U_ID == id);
                        ViewBag.U_State = new SelectList(new Models.U_StateDataSource().dataSource, "Id", "U_State",user.U_State);
            ViewData.Model = user;
            return PartialView();
        }


        [HttpPost]
        public ActionResult Edit(Users users)
        {
            
            if (ModelState.IsValid)
            {
                this.services.UpdateEntity(users);
            }

            return View();
        }
        
        #endregion

        #region 2.0 删除+Delete

        [HttpGet]
        public ActionResult PartialDelete(int id)
        {
            Users user = services.GetEntityByLambada(u => u.U_ID == id);
            ViewBag.id = id;
            ViewBag.U_Name = user.U_Name;
            return PartialView();
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            Users user = services.GetEntityByLambada(u => u.U_ID == id);
            services.DeleteEntity(user);
            return RedirectToAction("index");
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

        #region 3.0 详细+Detail
        public ActionResult PartialDetail(int id)
        {
           Users user = services.GetEntityByLambada(u => u.U_ID == id);
           ViewData.Model = user;
           ViewBag.id = id;
           ViewBag.Campuscard  = user.U_CompusCard.Split(';');
            return PartialView();
        }
        #endregion
        
    }
}
