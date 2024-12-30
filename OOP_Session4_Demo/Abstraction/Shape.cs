using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4_Demo.Abstraction
{
    // Abstract Class
    //Is a class containing function partial implementation for another class
    // you can not create object from an abstract class because it is not fully implemented
    internal abstract class Shape
    {
        public Shape(decimal _Dim01, decimal _Dim02)
        {
            Dim01 = _Dim01;
            Dim02 = _Dim02;
        }
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        public abstract decimal perimeter { get; }
        //Abstract Method
        public abstract decimal CalcArea();
    }
}
