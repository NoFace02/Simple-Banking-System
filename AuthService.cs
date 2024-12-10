using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking_System
{
    public class AuthService
    {
        public List<User> users = new List<User>();

        public void SignUp(User UserID)
        {
            
            users.Add(UserID);
            Console.WriteLine("test");
        }
        
        public User Login(string userid, string userpassword)
        {
            var user = users.FirstOrDefault(u => u.UserID == userid && u.UserPassword == userpassword );
            if (user != null)
            {
                Console.WriteLine("Login successful."); 
                return user; 
            }
            Console.WriteLine("Invalid credentials.");
            return null;
        }
    }
}
