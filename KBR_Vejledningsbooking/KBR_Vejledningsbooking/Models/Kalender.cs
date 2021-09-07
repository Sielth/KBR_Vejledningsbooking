using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBR_Vejledningsbooking.Models
{
    public class Kalender
    {
        public int KalenderID { get; }
        public Bookingvindue bookingvindue { get; set; }
        public Hold hold { get; set; }
    }
}
