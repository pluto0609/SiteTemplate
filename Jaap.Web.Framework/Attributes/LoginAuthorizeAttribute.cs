using System.Web.Management;
using System.Web.Mvc;
using Jaap.Framework;

namespace Jaap.Web.Framework.Attributes
{
    /// <summary>
    /// 登录授权过滤器
    /// </summary>
    public class LoginAuthorizeAttribute:AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var userName = CookieHelper.GetCookieValue("username");
            if (!userName.IsNullOrEmpty()) return;
            var loginUrl = ConfigHelper.Get("loginUrl");
            filterContext.Result = new RedirectResult(loginUrl + "?redirectUrl=" + filterContext.HttpContext.Request.Url);
        }
    }
}