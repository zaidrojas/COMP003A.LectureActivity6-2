using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    /// <summary>
    /// Repersents a circle with a specific area calculation.
    /// </summary>
    class Circle : Shape
    {
        // Auto-implemented propery for the radius of the circle.
        public double Radius { get; set; }

        /// <summary>
        /// Constructor for the Circle class
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Displays the area of a circle.
        /// </summary>
        public override void DisplayArea()
        {
            Console.WriteLine($"Circle Area: {Math.PI * Radius * Radius}");
        }
    }

}
