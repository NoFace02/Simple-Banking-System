using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AuthService authService = new AuthService();
            BankingService bankingService = new BankingService();
            while (true)
            {
                Console.WriteLine("||==============||");
                Console.WriteLine("||Simple Banking||");
                Console.WriteLine("||==============||");
                Console.WriteLine("\n");
                Console.WriteLine("1. Sign Up");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Enter your First Name: ");
                    var firstname = Console.ReadLine();
                    Console.WriteLine("Enter your Last Name: ");
                    var lastname = Console.ReadLine();
                    Console.WriteLine("Enter your age: ");
                    var userage = Console.ReadLine();
                    Console.WriteLine("Enter your Social Security Number: ");
                    var socialsecuritynumber = Console.ReadLine();
                    Console.WriteLine("Enter your email address: ");
                    var email = Console.ReadLine();
                    Console.WriteLine("Enter your phone number:");
                    var phonenumber = Console.ReadLine();
                    Console.WriteLine("Enter your home address:");
                    var address = Console.ReadLine();



                    Random random = new Random();
                    string userID = random.Next(10000000, 100000000).ToString("D8");
                    User user = new User { FirstName = firstname, LastName = lastname, UserAge = int.Parse(userage), SocialSecurityNumber = socialsecuritynumber, Email = email, PhoneNumber = phonenumber, Address = address };

                    Console.WriteLine("Your registration was succesfull, this are your Log in details:");
                    Console.WriteLine($"");
                }
                else if (choice == "2")
                {

                }













            }
        }
    }
}
