﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteTemplate.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return Redirect(Url.Action("index", "Template"));
        }
    }
}