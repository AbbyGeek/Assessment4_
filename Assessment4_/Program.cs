using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4_
{
    class Program
    {
        static void Main(string[] args)
        {

            // problem 1
            //create abstract drone class with:
            //-int variables totalFlyTime(min) and totalDistance(feet)(all private)
            //-constructor with overloads
            //-public abstract method named FlightSpeed that takes totalFlyTime and totalDistance and returns calculatedSpeed)
            //Create a QuadrotorDrone class that:
            //-extends Drone
            //-implements flightSpeed method that changes instance variables totalFlyTime and totalDistance by adding totalFlyTime1 and totalDistance1 respecively.
            //Leave a somment explaining how you applied he SOLID principles to this challenge
            
            QuadRotorDrone sparky = new QuadRotorDrone(5,5,5,5);

            Console.WriteLine(sparky.FlightSpeed(5,50));


            //Problem 2
            /// Create an Shape class with virtual method called Draw() that prints "Hi, I am a shape"
            ///create the class square, inherit Shape.
            ///Create override method for Draw in Square that prints "Hi, I am a square"
            ///The class square has method GetArea(). Returns area of square.Square class has field called "side"
            ///For square class you need a no-argument constructor to initialize side to zero
            ///you need overloaded constructor to initialize side
            ///code property for a side
            ///leave comment about SOLID principals.
            ///


            //Problem 3
            int[] array1 = { 1, 2,3,4,5,6};
            int i = 0;
            for (i = 0; i < array1.Length; i++)
            {
                array1[i]++;
            }
            int result = GetSum(array1);
            Console.WriteLine(result);
        }
        private static int GetSum(int[] array1)
        {
            int sum = 0;
            foreach (int item in array1)
            {
                sum = sum + item;
            }
            return sum;
        }
    }
}
