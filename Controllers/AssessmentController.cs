using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Mvc;
using Sitecore.Mvc.Presentation;
using Sitecore.Mvc.Helpers;
using Sitecore.Data;
namespace Sarthak.Controllers
{
    public class AssessmentController : Sitecore.Mvc.Controllers.SitecoreController

    {
        // GET: Assessment
        public ActionResult Header()
        {
            var data = RenderingContext.Current.Rendering.Item;
            return View(data);
        }
        public ActionResult Footer()
        {
            var data= RenderingContext.Current.Rendering.Item;  
            return View(data);
        }
    }
}