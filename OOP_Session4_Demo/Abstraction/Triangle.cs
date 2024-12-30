using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4_Demo.Abstraction
{
    internal class Triangle : Shape
    {
        public decimal Dim03 { get; set; }
        public Triangle(decimal _Dim01, decimal _Dim02, decimal _Dim03) : base(_Dim01,_Dim02)
        {
            Dim03 = _Dim03; 
        }
        public override decimal perimeter => throw new NotImplementedException();

        public override decimal CalcArea()
        {
            throw new NotImplementedException();
        }
    }
}
