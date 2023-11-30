using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Webcenter.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = " Yêu cầu nhập tên đăng nhập")]
        [Display(Name = "ten dang nhap")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập mật khẩu")]
        [Display(Name = "mat khau")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
