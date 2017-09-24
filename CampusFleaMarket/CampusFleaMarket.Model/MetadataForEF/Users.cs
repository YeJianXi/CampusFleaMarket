using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusFleaMarket.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.Web;
    using Filter;

    [MetadataType(typeof(UsersMetadata))]
    public partial class Users
    {
        private class UsersMetadata
        {
            [Required]
            [Display(Name = "学号")]
            public string U_StuNumber { get; set; }
            [Required]
            [Display(Name = "用户名")]
            public string U_Name { get; set; }
            [Required]
            [Display(Name = "密码")]
            public string U_Passward { get; set; }
            [Required]
            [Display(Name = "电话")]
            public string U_Phone { get; set; }
            [Display(Name = "头像")]
            public string U_HeadImage { get; set; }
            public string U_CompusCard { get; set; }
            [Required]
            [Display(Name = "审核状态")]
            public string U_State { get; set; }
        }
        [Display(Name = "头像")]
        //[Required(ErrorMessage = "请上传你的头像图片！")]
        //[ValidateFile]
        public HttpPostedFileBase Head_Image { get; set; }
        [Display(Name = "校园卡")]
        //[Required(ErrorMessage = "请上传你的校园卡图片！")]
        //[ValidateFile]
        public HttpPostedFileBase[] CompusCard { get; set; }
    }
}
