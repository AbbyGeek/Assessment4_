using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4_
{
    public abstract class Drone
    {
        private int TotalFlyTime { get; set; }
        private int TotalDistane { get; set; }

        public Drone(int TotalFlyTime, int TotalDistance)
        {

        }

        public virtual double FlightSpeed(int TotalFlyTime, int TotalDistance)
        {
            return TotalDistance / TotalFlyTime;
        }
    }
}
