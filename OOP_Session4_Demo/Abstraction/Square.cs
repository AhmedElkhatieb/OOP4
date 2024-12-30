using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4_Demo.Abstraction
{
    internal class Square : Base
    {
        public Square(decimal _Dim):base(_Dim, _Dim)
        {
        }
        public override decimal perimeter
        {
            get
            {
                return Dim01 * 4;
            }
        }

        
    }
}
