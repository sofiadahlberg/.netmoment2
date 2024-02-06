using MyApp.Namespace;
using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using momentMVC.Models;

namespace MyApp.Namespace
{
    public class StartController : Controller
    {


        // GET: StartController
        public ActionResult Index()
        {
            /*Nedladdat paket Nuget Newtonsoft.json*/
            var jsonStr = System.IO.File.ReadAllText("TimeTable.json");
            var JsonObject = JsonConvert.DeserializeObject<IEnumerable<TimeTable>>(jsonStr);
            return View(JsonObject);
        }
        [Route("/About")]
        public ActionResult About()
        {
            return View();
        }

        [Route("/ViewBagTest")]
        public ActionResult ViewBagTest()
        {
            string s = "Detta är en text";
            int o = 10;

            ViewBag.error = s;
            ViewData["TheName"] = o;

            return View();
        }





    }
}
