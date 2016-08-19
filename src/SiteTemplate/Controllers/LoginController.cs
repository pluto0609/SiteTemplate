using System;
using System.Web.Mvc;
using Jaap.Framework;
using Jaap.Web.Framework;
using Microsoft.Ajax.Utilities;

namespace SiteTemplate.Controllers
{
    [RoutePrefix("login")]
    public class LoginController : BaseController
    {
        public ActionResult Index(string redirectUrl)
        {
            if (redirectUrl.IsNullOrEmpty()) redirectUrl = Url.Action("Index", "Home");
            ViewBag.RedirectUrl = redirectUrl;
            ViewBag.UserName = CookieHelper.GetCookieValue("username");
            return View();
        }

        [Route("login")]
        public JsonResult Login(string userName, string password)
        {
            if (userName.IsNullOrEmpty()) return Fail("用户名不能为空");
            if (password.IsNullOrEmpty()) return Fail("密码不能为空");
            if (password.Length <= 6) return Fail("密码长度不能小于6");
            if (userName == "admin" && password == "1234567")
            {
                CookieHelper.SetCookie("username", userName, DateTime.Now.AddMinutes(5));
                return Success("登录成功");
            }
            return Fail("登录失败");
        }
    }
}