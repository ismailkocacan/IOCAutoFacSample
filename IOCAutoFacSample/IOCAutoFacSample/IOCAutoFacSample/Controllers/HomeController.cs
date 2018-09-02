using IOCAutoFacSample.Model;
using IOCAutoFacSample.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IOCAutoFacSample.Controllers
{
    public class HomeController : Controller
    {
        IEntityService entityService;
        public HomeController(IEntityService entityService)
        {
            this.entityService = entityService;
        }


        public ActionResult Index()
        {
            IList<Entity> list = entityService.GetList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}