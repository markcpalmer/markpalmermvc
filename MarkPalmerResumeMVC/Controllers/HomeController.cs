using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarkPalmerResumeMVC.Models;

namespace MarkPalmerResumeMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ResumeObject> resume = new List<ResumeObject>();
            using (ResumeObjectsDataContext dc= new ResumeObjectsDataContext())
            {
                var query = dc.ResumeObjects.Select(a => a);
                foreach(var item in query)
                {
                    resume.Add(item);
                }

            }
            return View(resume);
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