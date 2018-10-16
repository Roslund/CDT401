using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebComponent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Download()
        {
            var componentID = this.Request.QueryString["id"];
            if (componentID == null)
            {
                return new HttpNotFoundResult("No Component specified");
            }

            byte[] compBinary = null;
            return File(compBinary, "application/x-msdownload");
        }
    }
}