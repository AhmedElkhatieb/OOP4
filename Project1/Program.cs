namespace Project1
{
    internal class Program
    {
        static Point3D ReadPoint ()
        {
            decimal[] Coordinates = new decimal[3];
            Console.WriteLine("Enter X Coordinate:");
            while (true)
            {
                bool FlagX = decimal.TryParse(Console.ReadLine(), out Coordinates[0]);
                if (FlagX)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter A Valid Number!");
                }
            }
            Console.WriteLine("Enter Y Coordinate:");
            while (true)
            {
                bool FlagY = decimal.TryParse(Console.ReadLine(), out Coordinates[1]);
                if (FlagY)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter A Valid Number!");
                }
            }
            Console.WriteLine("Enter Z Coordinate:");
            while (true)
            {
                bool FlagZ = decimal.TryParse(Console.ReadLine(), out Coordinates[2]);
                if (FlagZ)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter A Valid Number!");
                }
            }
            return new Point3D()
            {
                X = Coordinates[0],
                Y = Coordinates[1],
                Z = Coordinates[2]
            };
            
        }
        
        static void Main(string[] args)
        {
            #region 3
            //Console.WriteLine("Enter Coordinates For Point 1:");
            //Point3D P1 = ReadPoint();
            //Console.WriteLine("Enter Coordinates For Point 2:");
            //Point3D P2 = ReadPoint(); 
            #endregion
            #region 4
            //if (P1 == P2)
            //{
            //    Console.WriteLine("P1 = P2");
            //}
            //else
            //{
            //    Console.WriteLine("P1 != P2");
            //} 
            // Won't Work Properly 
            // it will return true if and only if P1 and P2 are refering to the same object
            // (Same Address in memory)
            // To make It Work Properly, We Must Use operator overloading
            #endregion

            #region 5
            //Point3D[] point3Ds = new Point3D[]
            //{
            //new Point3D(3, 4, 5),
            //new Point3D(1, 2, 3),
            //new Point3D(3, 2, 1),
            //new Point3D(2, 2, 2),
            //new Point3D(1, 3, 3)
            //};
            //Console.WriteLine("Unsorted:");
            //foreach (Point3D point in point3Ds)
            //{
            //    Console.WriteLine(point);
            //}
            //Array.Sort<Point3D>(point3Ds);
            //Console.WriteLine("Sorted");
            //foreach (Point3D point in point3Ds)
            //{
            //    Console.WriteLine(point);
            //}
            #endregion
            #region 6
            //Point3D P;
            //Point3D P1 = new Point3D(1, 2, 3);
            //Point3D P2 = (Point3D)P1.Clone();
            //Console.WriteLine(P2);
            #endregion
        }
    }
}
