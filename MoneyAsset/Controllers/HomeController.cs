using MoneyAsset.Models;
using MoneyAsset.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyAsset.Controllers
{

    public class HomeController : Controller
    {
        private SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();

        public ActionResult Index()
        {
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
        //[ChildActionOnly]
        public ActionResult Details()
        {
            var results = db.AccountBook.OrderBy(p=>p.Dateee).Take(10);
            return View(results);
        }

        private static List<DetailsViewModels> GetMoneyData()
        {
            List<DetailsViewModels> results = new List<DetailsViewModels> {
               new DetailsViewModels {Id=1, Categories="支出", Cost=300, CreateDate=new DateTime(2016,1,3) },
               new DetailsViewModels {Id=2, Categories="支出", Cost=1600,CreateDate=new DateTime(2016,3,10) },
               new DetailsViewModels {Id=3, Categories="支出", Cost=800, CreateDate=new DateTime(2016,4,1) }
           };

            return results;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}