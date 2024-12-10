using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking_System
{
    public class AuthService
    {
        private List<User> users = new List<User>();

        public void SignUp(User user)
        {
            if (users.Any(u => u.UserID == user.UserID))
            {
                Console.WriteLine("Username already exists."); 
                return;
            }

            users.Add(user);
            Console.WriteLine("User signed up successfully.");
        }
        /*public User Login(string UserID, string UserPassword)
        {
            var user = users.FirstOrDefault(u => u.UserID == Userid && u.UserPassword == password);
            if (user != null)
            {
                Console.WriteLine("Login successful."); 
                return user; 
            }
            Console.WriteLine("Invalid credentials.");
            return null;
        }*/
    }
}
