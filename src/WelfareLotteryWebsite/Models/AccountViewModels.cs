using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Mvc.Rendering;

namespace WelfareLotteryWebsite.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "请输入有效的电子邮箱")]
        public string Email { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress, ErrorMessage = "请输入有效的电子邮箱")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "请输入有效的电子邮箱")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        //[Required]
        //[Display(Name = "Email")]
        //[EmailAddress]
        //public string Email { get; set; }
        
        [Required]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Display(Name = "手机号码")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "邮箱")]
        [DataType(DataType.EmailAddress,ErrorMessage = "请输入有效的电子邮箱")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0}至少需要{2}位", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = "两次输入密码不一致")]
        public string ConfirmPassword { get; set; }
    }

    public class EditUserViewModel
    {
        public EditUserViewModel() { }
        // Allow Initialization with an instance of ApplicationUser:
        public EditUserViewModel(ApplicationUser user)
        {
            this.Id = user.Id;
            this.UserName = user.UserName;
            this.PhoneNumber = user.PhoneNumber;
            this.Email = user.Email;
        }

        [Required]
        public string Id { get; set; }
        [Required]
        [Display(Name = "使用者账号")]
        public string UserName { get; set; }
        //[Required]
        [Display(Name = "手机号码")]
        [Phone(ErrorMessage = "请输入有效的电话号码")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "电子邮件信箱")]
        [EmailAddress(ErrorMessage = "请输入有效的电子邮箱")]
        public string Email { get; set; }
    }

    public class SelectUserRolesViewModel
    {
        public SelectUserRolesViewModel()
        {
            this.Roles = new List<SelectRoleEditorViewModel>();
        }
        // Enable initialization with an instance of ApplicationUser:
        public SelectUserRolesViewModel(ApplicationUser user,string connectionString)
        : this()
        {
            this.Id = user.Id;
            this.UserName = user.UserName;
            this.PhoneNumber = user.PhoneNumber;
            this.Email = user.Email;
            var Db = new ApplicationDbContext {outConnectionString = connectionString};
            // Add all available roles to the list of EditorViewModels:
            var allRoles = Db.Roles;
            foreach (var role in allRoles)
            {
                // An EditorViewModel will be used by Editor Template:
                var rvm = new SelectRoleEditorViewModel(role);
                this.Roles.Add(rvm);
            }
            // Set the Selected property to true for those roles for
            // which the current user is a member:
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(Db), null, new PasswordHasher<ApplicationUser>(), null, null, null, null, null, null, null);

            IList<string> roles = um.GetRolesAsync(user).Result;
            foreach (var userRole in roles)
            {
                var checkUserRole =
        this.Roles.Find(r => r.RoleName == userRole);//userRole.Role.Name
                checkUserRole.Selected = true;
            }
        }
        /// <summary>
        /// 用户Id
        /// </summary>
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<SelectRoleEditorViewModel> Roles { get; set; }
    }
    // Used to display a single role with a checkbox, within a list structure:
    public class SelectRoleEditorViewModel
    {
        public SelectRoleEditorViewModel() { }
        public SelectRoleEditorViewModel(IdentityRole role)
        {
            this.RoleName = role.Name;
        }
        public bool Selected { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
