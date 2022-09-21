using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Ride Class to set Data for Particular Ride
    /// </summary>
    public class Ride
    {
        public double distance;
        public int time;
        /// <summary>
        /// Parameter Constructor for Setting data
        /// </summary>
        
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
