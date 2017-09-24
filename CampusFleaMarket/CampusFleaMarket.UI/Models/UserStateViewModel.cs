using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusFleaMarket.UI.Models
{
    public class UserStateViewModel
    {
        public int Id { get; set; }
        public string U_State { get; set; }


    }












    public class U_StateDataSource
    {
       public   List<Models.UserStateViewModel> dataSource = new List<Models.UserStateViewModel>();
        public U_StateDataSource()
        {
            dataSource.Add(new Models.UserStateViewModel() { Id = 0, U_State = "未通过" });
            dataSource.Add(new Models.UserStateViewModel() { Id = 1, U_State = "已通过" });
        }
      
    }

}