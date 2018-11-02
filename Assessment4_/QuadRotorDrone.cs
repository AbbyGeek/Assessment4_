using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4_
{
    class QuadRotorDrone : Drone
    {
        public int totalFlyTime1 { get; set; }
        public int totalDistance1 { get; set; }

        public QuadRotorDrone(int totalFlyTime1, int totalDistance1, int TotalFlyTime, int TotalDistance) : base(TotalFlyTime, TotalDistance) { }

        public override double FlightSpeed(int TotalFlyTime, int TotalDistance)
        {
            //return base.FlightSpeed(TotalFlyTime, TotalDistance);
            
            return (double)(TotalFlyTime+totalFlyTime1)/(TotalDistance+totalDistance1);
        }

        //SOLID PRINCIPALS
        //used one method per class. Quad Rotor is derrived directly from the Drone and implemented in the main program. We were also able to acess the abstract method for Flightspeed and tailor it for the quaddrone without messing with the abstract class.
    }
}
