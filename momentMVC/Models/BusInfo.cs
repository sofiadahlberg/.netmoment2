using System;
namespace momentMVC.Models
{
    public class BusInfo
    {
        // Class properties and methods
        public int? FreeSeats { get; set; }
        public int? TakenSeats { get; set; }
        public int? TotalSeats { get; set; }
    }

    public class BusInformationViewModel
    {
        public BusInfo? Bus1 { get; set; }
        public BusInfo? Bus2 { get; set; }
        public BusInfo? Bus3 { get; set; }
    }


}