using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBR_Vejledningsbooking.Models
{
    public class Underviser
    {
        public int UnderviserID { get; }
        public Kalender kalender { get; set; }
    }
}
