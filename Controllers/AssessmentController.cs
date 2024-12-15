using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Mvc;

namespace Sarthak.Controllers
{
    public class AssessmentController : Sitecore.Mvc.Controllers.SitecoreController

    {
        // GET: Assessment
        public ActionResult Header()
        {
            return View();
        }
        public ActionResult Footer()
        {
            return View();
        }
    }
}