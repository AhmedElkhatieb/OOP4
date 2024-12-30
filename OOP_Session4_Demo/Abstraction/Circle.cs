using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4_Demo.Abstraction
{
    internal class Circle : Shape
    {
        public Circle(decimal _Radius):base(_Radius, _Radius)
        {
        }
        public override decimal perimeter
        {
            get
            {
                return 2 * 3.14m * Dim01;
            }
        }

        public override decimal CalcArea()
        {
            return 3.14m * Dim01 * Dim02;
        }
    }
}
