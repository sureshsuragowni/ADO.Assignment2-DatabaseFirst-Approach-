using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusInfo.Models
{
    public class Businformation
    {
        public int BusID { get; set; }
        public string BoardingPoint { get; set; }
        public Nullable<System.DateTime> TravelDate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Rating { get; set; }
    }
}