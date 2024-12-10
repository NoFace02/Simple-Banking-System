using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking_System
{
    public class Account
    {
        public int AccountID {  get; set; }
        public string AccountType { get; set; }
        public int UserID { get; set; }
        public decimal Balance { get; set; }

        public void Deposit (decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }

        }
        public void Transfer(Account targetAccount, decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                targetAccount.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

    }
}
