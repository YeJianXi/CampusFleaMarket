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
    public class UsersService:BaseService<Users>,IUserService
    {
        public override IDAL.IBaseDal<Users> CurrentDal
        {
            get
            {
                return FactoryDalContext.GetCurrentDalContext().UsersDal;
            }
            
        }

        public override bool DeleteEntitys(string[] select)
        {
            try
            {
                foreach (string item in select)
                {
                    Users u = CurrentDal.GetEntityByLambada(m => m.U_ID == int.Parse(item));
                    CurrentDal.DeleteEntity(u);
                }
            }
            catch {
                throw new Exception("ID不能为空");
            }

            return DC.SaveChange()>=select.Length;
        }
    }
}
