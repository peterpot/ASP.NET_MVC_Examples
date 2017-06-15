using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//
using BLL;
using DAL.EF;

namespace WebSiteExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            BLLCareers careersBLL = new BLLCareers();
            var careers = careersBLL.GetCareersALL();
            return View(careers);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: Context
    //    public ActionResult Context()
    //    {
    //        var model = Request.Headers
    //        return View(model);
    //    }
    }
}