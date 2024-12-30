using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override string ToString()
        {
            if (Hours == 0)
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else if (Hours == 0 && Minutes == 0)
            {
                return $"Seconds: {Seconds}";

            }
            else
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";

            }
        }
        public override bool Equals(object? obj)
        {
            if (obj is Duration otherDuration)
            {
                return Hours == otherDuration.Hours && Minutes == otherDuration.Minutes && Seconds == otherDuration.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public Duration(int _Hours, int _Minutes, int _Seconds)
        {
            Hours = _Hours;
            Minutes = _Minutes;
            Seconds = _Seconds;
        }
        public Duration(int _Seconds)
        {
            Hours = _Seconds / 3600;
            _Seconds = _Seconds - Hours * 3600;
            Minutes = _Seconds / 60;
            _Seconds = _Seconds - Minutes * 60;
            Seconds = _Seconds;
        }

        public static int ToSeconds (Duration D)
        {
            return D.Hours * 3600 + D.Minutes * 60 + D.Seconds;
        }

        public static Duration operator +(Duration DLeft, Duration DRight)
        {
            int TotalSeconds = ToSeconds(DLeft) + ToSeconds(DRight);
            return new Duration(TotalSeconds);
        }
        public static Duration operator +(Duration D, int Seconds)
        {
            int TotalSeconds = ToSeconds(D) + Seconds;
            return new Duration(TotalSeconds);
        }
        public static Duration operator +(int Seconds, Duration D)
        {
            int TotalSeconds = ToSeconds(D) + Seconds;
            return new Duration(TotalSeconds);
        }
        public static Duration operator ++(Duration D)
        {
            int TotalSeconds = ToSeconds(D) + 60;
            return new Duration(TotalSeconds);
        }
        public static Duration operator --(Duration D)
        {
            int TotalSeconds = ToSeconds(D) - 60;
            if (TotalSeconds < 60)
            {
                throw new Exception("Duration is less than 1 min!");
            }
            return new Duration(TotalSeconds);
        }
        public static Duration operator -(Duration DLeft, Duration DRight)
        {
            int TotalSeconds = ToSeconds(DLeft) - ToSeconds(DRight);
            if (TotalSeconds < 0)
            {
                throw new Exception("Can't do Subtraction as the second operand os larger than the first operand!");
            }
            return new Duration(TotalSeconds);
        }
        public static bool operator >(Duration DLeft, Duration DRight)
        {
            int TotalSeconds1 = ToSeconds(DLeft);
            int TotalSeconds2 = ToSeconds(DRight);
            return TotalSeconds1 > TotalSeconds2;
        }
        public static bool operator <(Duration DLeft, Duration DRight)
        {
            int TotalSeconds1 = ToSeconds(DLeft);
            int TotalSeconds2 = ToSeconds(DRight);
            return TotalSeconds1 < TotalSeconds2;
        }
        public static bool operator >=(Duration DLeft, Duration DRight)
        {
            int TotalSeconds1 = ToSeconds(DLeft);
            int TotalSeconds2 = ToSeconds(DRight);
            return TotalSeconds1 >= TotalSeconds2;
        }
        public static bool operator <=(Duration DLeft, Duration DRight)
        {
            int TotalSeconds1 = ToSeconds(DLeft);
            int TotalSeconds2 = ToSeconds(DRight);
            return TotalSeconds1 <= TotalSeconds2;
        }
        public static explicit operator bool(Duration D)
        {
            return ToSeconds(D) != 0;
        }
        public static explicit operator DateTime(Duration D)
        {
            return new DateTime(2024,12,30,D.Hours, D.Minutes, D.Seconds);
        }
    }
}
