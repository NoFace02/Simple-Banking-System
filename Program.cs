using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking_System
{
    class Program
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


                try
                {
                    if (choice == "1")
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Clear();
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

                                string UserPassword(int length)
                                {
                                    const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                                    char[] userpassword1 = new char[chars.Length];
                                    Random random1 = new Random();
                                    for (int i = 0; i < length; i++)
                                    {
                                        userpassword1[i] = chars[random1.Next(chars.Length)];
                                    }
                                    return new string(userpassword1);
                                }
                                string userpassword = UserPassword(8);

                                Random random = new Random();
                                string userid = random.Next(10000000, 100000000).ToString("D8");
                                User user = new User
                                {
                                    FirstName = firstname,
                                    LastName = lastname,
                                    UserAge = int.Parse(userage),
                                    SocialSecurityNumber = socialsecuritynumber,
                                    Email = email,
                                    PhoneNumber = phonenumber,
                                    Address = address,
                                    UserID = userid,
                                    UserPassword = userpassword
                                };
                                authService.SignUp(user);

                                Console.WriteLine("Your registration was succesfull, this are your Log in details:");
                                Console.WriteLine($"UserID:{userid}");
                                Console.WriteLine($"Password:{userpassword}");
                                break;
                            }

                            catch
                            {
                                Console.WriteLine("Invalid input. Press any button to try again!");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Enter Your UserID");
                        string userid = Console.ReadLine();
                        Console.WriteLine("Enter Your Password");
                        string userpassword = Console.ReadLine();
                        User user = authService.Login(userid, userpassword);

                        if (user != null)
                        {
                            while (true)
                            {
                                Console.WriteLine("1. Create Account");
                                Console.WriteLine("2. Deposit");
                                Console.WriteLine("3. Withdraw");
                                Console.WriteLine("4. Transfer");
                                Console.WriteLine("5. View Balance");
                                Console.WriteLine("6. Logout");
                                var operationChoice = Console.ReadLine();
                                
                            }
                        }
                    }
                    else if (choice == "3")
                    { break; }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Press any button to try again!");
                    Console.ReadKey();
                    Console.Clear();
                }














            }
        }
    }

}
