using System;

namespace AccessorPractice
{

    // blueprint for a cashier's profile
    class CashierClass
    {
        public string Name { get; set; }
        public int TeamMemberID { get; set; }
        public string Email { get; set; }
        public double Bonus { get; set; }
        private string Password { get; set; }


        public CashierClass(string name, int tmid, string email, double bonus)
        {
            Name = name;
            Email = email;
            TeamMemberID = tmid;
            Bonus = bonus;
        }

        public string EmployeePassword
        {
            get
            {
                return Password;
            }
            set
            {
                if(value.Length > 7)
                {
                    Password = value;
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // initialize new object/cashier
            CashierClass newHire = new CashierClass("Greg", 2139839, "gregsmith446@gmail.com", 125.75);

            // set password
            newHire.EmployeePassword = "password123";

            Console.WriteLine("New Hire info is as follows: " + newHire.Name + newHire.TeamMemberID + newHire.Email + newHire.Bonus);

            Console.WriteLine(newHire.EmployeePassword);
        }
    }
}
