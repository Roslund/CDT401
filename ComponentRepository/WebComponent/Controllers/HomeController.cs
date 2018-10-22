using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepositoryComponent;

namespace WebComponent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IWeb repo = new RepositoryService();
            ViewBag.Components = repo.GetComponents();
            return View();
        }

        public ActionResult Download(int id)
        {
            IWeb repo = new RepositoryService();
            // application/x-msdownload
            var (content, fileName) = repo.DownloadComponent(id);
            return File(content, "application/octet-stream", fileName);
        }
    }
}