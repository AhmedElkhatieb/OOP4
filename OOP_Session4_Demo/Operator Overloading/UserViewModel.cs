using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4_Demo.Operator_Overloading
{
    // Is a class represents the data that will be rendered in view (HTML)
    internal class UserViewModel
    {
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public static explicit operator UserViewModel(User user)
        {
            string[]? Names = user?.FullName.Split(" ");
            return new UserViewModel()
            {
                Email = user?.Email??string.Empty,
                Password = user?.Password??string.Empty,
                FName = Names?.Length > 0 ? Names[0] : string.Empty,
                LName = Names?.Length > 1 ? Names[1] : string.Empty,

            };

        }
    }
}
