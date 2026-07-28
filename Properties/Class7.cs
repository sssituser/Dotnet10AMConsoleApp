using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Area
    {
        public int Length { get; set; }
        public int Breadh { get; set; }

        public int Side { get; set; }

        public double Radius { get; set; }


        public int AreaOfRectangle
        {
            get
            {
                return Length * Breadh;
            }
        }
      

        public int AreaOfSquare
        {
            get { 
                return Side*Side; 
            }
           

        }

        public double AreaOfCircle
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

    }
    internal class Class7
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            area.Length = 5;
            area.Breadh = 2;
            area.Side = 3;
            area.Radius = 3.5;

            Console.WriteLine($"Area of Rectangle :{area.AreaOfRectangle}");
            Console.WriteLine($"Area of a Square :{area.AreaOfSquare}");
            Console.WriteLine($"Area of a Circle :{area.AreaOfCircle}");



        }
    }
}
