using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4_Demo.Abstraction
{
    // Cocrete Class
    internal class Rect : Base // Inherite and implement
    {
        public Rect(decimal _Dim01, decimal _Dim02):base(_Dim01, _Dim02)
        {
        }
        public override decimal perimeter
        {
            get
            {
                return (Dim01 + Dim02) * 2;
            }
        }

        
    }
}
