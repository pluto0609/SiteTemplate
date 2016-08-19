using System.Web.Mvc;
using Jaap.Web.Framework.Attributes;

namespace SiteTemplate.Controllers
{
    /// <summary>
    /// 模板控制器
    /// </summary>
    [LoginAuthorize]
    public class TemplateController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}