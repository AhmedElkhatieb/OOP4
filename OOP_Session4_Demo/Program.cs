using OOP_Session4_Demo.Abstraction;
using OOP_Session4_Demo.Operator_Overloading;

namespace OOP_Session4_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator Overloading
            Complex C1 = new Complex() { Real = 2, Imag = 4 };
            Complex C2 = new Complex() { Real = 3, Imag = 5 };
            #region Binary Operators
            //Complex C3 = C1 + C2;
            //Complex C4 = C1 + C2 + C3;
            //Complex C5 = C1 - C2;
            //Console.WriteLine($"C1 = {C1}");
            //Console.WriteLine($"C2 = {C2}");
            //Console.WriteLine($"C3 = {C3}");
            //Console.WriteLine($"C4 = {C4}");
            //Console.WriteLine($"C5 = {C5}");
            #endregion
            #region Unary Operators
            //Console.WriteLine($"C1 = {C1}");
            //Console.WriteLine($"C2 = {C2}");
            //Complex C3 = ++C1;
            //Complex C4 = --C2;
            //Console.WriteLine($"C3 = {C3}");
            //Console.WriteLine($"C4 = {C4}");
            #endregion
            #region Relational Operators
            //if (C1 > C2)
            //{
            //    Console.WriteLine("C1 is larger than C2");
            //}
            //else if (C2 > C1)
            //{
            //    Console.WriteLine("C1 is smaller than C2");
            //}
            //else
            //{
            //    Console.WriteLine("C1 = C2");
            //}
            #endregion
            #region Casting Operators
            //// int
            //int Y = (int)C1; // Explicit cating through overloading
            //object obj = 3; // implicit casting
            //int X = (int)obj; // explicit casting
            //Console.WriteLine(Y);
            ////string
            //string S2 = (string)C1;
            //object O2 = "Ahmed";
            //string S = (string)O2;
            //Console.WriteLine(S2);
            #endregion
            #region Busseniss Need For Casting Operators
            //User user = new User()
            //{
            //    Id = 2222,
            //    FullName = "Rana Hatem",
            //    Email = "Rana@gmail.com",
            //    Password = "222@50",
            //    SecurityStmp = Guid.NewGuid()
            //};
            //// Manual Mapping
            //UserViewModel userViewModel = (UserViewModel)user;
            //Console.WriteLine(userViewModel.FName);
            //Console.WriteLine(userViewModel.LName);
            //Console.WriteLine(userViewModel.Email);
            //Console.WriteLine(userViewModel.Password);
            #endregion
            #endregion
            #region Abstraction
            //Rect rect = new Rect()
            //{
            //    Dim01 = 10,
            //    Dim02 = 20
            //};
            //decimal rectArea = rect.CalcArea();
            //Console.WriteLine($"Area = {rectArea}");
            //decimal rectPerimeter = rect.perimeter;
            //Console.WriteLine($"Perimeter = {rectPerimeter}");
            Circle circle = new Circle(10);
            decimal CircleArea = circle.CalcArea();
            decimal CirclePerimeter = circle.perimeter;
            Console.WriteLine($"Circle Area = {CircleArea}");
            Console.WriteLine($"Circle Perimeter = {CirclePerimeter}");
            #endregion

        }
    }
}
