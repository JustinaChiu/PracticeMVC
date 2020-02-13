using PracticeMVC.Models;
using PracticeMVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var rand = new Random();
            //DateTime startDate = new DateTime(2018, 1, 1);
            //List<Records> recordList = new List<Records>();
            //for (int i = 0; i < 100; i++)
            //{
            //    Records item = new Records();
            //    item.Type = rand.Next(2);
            //    item.Date = startDate;
            //    item.Amount = rand.Next(10001);
            //    startDate = startDate.AddDays(rand.Next(3));
            //    recordList.Add(item);
            //}

            var recordList = AccountBookAPI.GetData().OrderBy(x => x.Date);
            return PartialView(recordList);
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