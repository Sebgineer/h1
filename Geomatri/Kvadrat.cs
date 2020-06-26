using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomatri
{
    public class Kvadrat
    {
        private double sides;
        public double Sides { get => sides; set => sides = value; }

        public Kvadrat (double sidesInCm)
        {
            this.sides = sidesInCm;
        }
        
        public double perimeter()
        {
            return 4 * this.sides;
        }

        public double Areal()
        {
            return (double)Math.Pow(this.sides, 2);
        }
    }
}
