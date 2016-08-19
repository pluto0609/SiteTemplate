using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Jaap.Web.Framework
{
    public class MvcBaseController : Controller
    {
        public JsonResult Success(string msg)
        {
            return Success("", msg);
        }
        public JsonResult Success(object data, string msg="")
        {
            return Json(new {S = 101, msg, data},JsonRequestBehavior.AllowGet);
        }

        public JsonResult Fail(string msg)
        {
            return Json(new {S = 201, msg = msg, list = ""},JsonRequestBehavior.AllowGet);
        }
    }
}
