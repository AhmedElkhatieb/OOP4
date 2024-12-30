using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Point3D:IComparable<Point3D>, ICloneable
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
        public Point3D(decimal _X, decimal _Y, decimal _Z)
        {
            X = _X;
            Y = _Y;
            Z = _Z;
        }
        public Point3D(decimal _X, decimal _Y):this(_X, _Y, 0)
        {
        }
        public Point3D():this(0, 0, 0)
        {
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }

        public int CompareTo(Point3D? other)
        {
            if (other == null)
            {
                return 1;
            }
            {

            }
            if (X < other.X)
            {
                return -1 ;
            }
            else if (X == other.X)
            {
                if (Y < other.Y)
                {
                    return -1;
                }
                else if (Y == other.Y)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 1;
            }
        }

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }

        public static bool operator ==(Point3D PLeft, Point3D PRight)
        {
            if (ReferenceEquals(PLeft, null) && ReferenceEquals(PRight, null))
                return true;

            if (ReferenceEquals(PLeft, null) || ReferenceEquals(PRight, null))
                return false;
            return PLeft.X == PRight.X && PLeft.Y == PRight.Y && PLeft.Z == PRight.Z;

        }
        public static bool operator !=(Point3D PLeft, Point3D PRight)
        {
            return !(PLeft == PRight);
        }
    }
}
