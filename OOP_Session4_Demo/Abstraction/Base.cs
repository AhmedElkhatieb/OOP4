using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4_Demo.Abstraction
{
    internal abstract class Base : Shape
    {
        public Base(decimal _Dim01, decimal _Dim02):base(_Dim01, _Dim02)
        {
        }
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }

    }
}
