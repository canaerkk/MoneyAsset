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
        [ChildActionOnly]
        public ActionResult Details()
        {
            var results = GetMoneyData();
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
    }
}