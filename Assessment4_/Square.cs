using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4_
{
    class Square : Shape
    {
        public float Side { get; set; }

        public Square()
        {
            Side = 0;
        }
        //overload constuctor
        public Square(float side)
        {
            Side = side;
        }

        public override void draw()
        {
            Console.WriteLine("I am a square!");
        }
        public double GetArea()
        {
            return Side * Side;
        }
    }
    // SOLID is used by us creating the shape class, and pulling directly from that class so we can use/override it, rather than modifying the Shape class to suit our square needs.
}
