using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking_System
{
    public class BankingService
    {
        public List<Account> accounts = new List<Account>();

        
        public void CreateAccount(Account account)
        {
            if (accounts.Any(a => a.AccountID == account.AccountID))
            {
                Console.WriteLine("Account ID already exists.");
                return;
            }

            accounts.Add(account);
            Console.WriteLine("Account created successfully.");
        }
        public void Deposit(int accountId, decimal amount)
        {
            var account = accounts.FirstOrDefault(a => a.AccountID == accountId);
            if (account != null)
            {
                account.Deposit(amount);
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        public void Withdraw(int accountId, decimal amount)
        {
            var account = accounts.FirstOrDefault(a => a.AccountID == accountId);
            if (account != null)
            {
                account.Withdraw(amount);
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        public void Transfer(int sourceAccountId, int targetAccountId, decimal amount)
        {
            var sourceAccount = accounts.FirstOrDefault(a => a.AccountID == sourceAccountId);
            var targetAccount = accounts.FirstOrDefault(a => a.AccountID == targetAccountId);

            if (sourceAccount != null && targetAccount != null)
            {
                sourceAccount.Transfer(targetAccount, amount);
                Console.WriteLine("Transfer successful.");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}
