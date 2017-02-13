using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightWebServices
{
    public class Travel
    {
        public int Code { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Time_Departure { get; set; }
        public DateTime Time_Arrived { get; set; }
        public TimeSpan Duration { get; set; }
        public int MaxCapacity { get; set; }
        public int MaxRow { get; set; }
        public int MaxSeatsRow { get; set; }
        public int CompanyID { get; set; }
        public bool Status { get; set; }
        public string CompanyName { get; set; }
        public string Origin_Destination { get; set; }
    }
}