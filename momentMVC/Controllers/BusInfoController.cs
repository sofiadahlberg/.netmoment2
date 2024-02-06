
using Microsoft.AspNetCore.Mvc;
using momentMVC.Models;
using MyApp.Namespace;

namespace MyApp.Namespace
{
    public class BusInfoController : Controller
    {
        public ActionResult Bus()
        {
            return View();
        }
        // GET: BusInfoController
        public ViewResult BusInformation()
        {
            // Skapa bussinformation
            BusInfo b1 = new BusInfo
            {
                FreeSeats = 30,
                TakenSeats = 30,
                TotalSeats = 60

            };

            // Skapa en ny buss med information
            BusInfo b2 = new BusInfo
            {
                FreeSeats = 10,
                TakenSeats = 20,
                TotalSeats = 30
            };
            //Skapa en tredje buss med information
            BusInfo b3 = new BusInfo
            {
                FreeSeats = 0,
                TakenSeats = 4,
                TotalSeats = 10
            };

            var viewModel = new BusInformationViewModel
            {
                Bus1 = b1,
                Bus2 = b2,
                Bus3 = b3
            };
            return View(viewModel);

        }
    }
}

