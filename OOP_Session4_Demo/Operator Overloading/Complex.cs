using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4_Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real {  get; set; }
        public int Imag { get; set; }
        #region Operator Overloading
        #region Binary Operators
        // overloading operator must be non private class member function
        public static Complex operator + (Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real??0) + (Right?.Real??0),
                Imag = (Left?.Imag??0) + (Right?.Imag??0)
            };
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };
        }
        #endregion
        #region Unary Operators
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0)
            };
        }
        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = (C?.Imag ?? 0)
            };
        }
        #endregion
        #region Relational Operators
        public static bool operator > (Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
            {
                return Left?.Imag > Right.Imag;
            }
            else
            {
                return Left.Real > Right.Real;
            }
        }
        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
            {
                return Left?.Imag < Right.Imag;
            }
            else
            {
                return Left.Real < Right.Real;
            }
        }
        #endregion
        #region Casting Operators
        public static explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }
        public static implicit operator string(Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }
        // Explicit is recommended: better readability and vs will remind u if u forget
        #endregion
        #endregion
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
