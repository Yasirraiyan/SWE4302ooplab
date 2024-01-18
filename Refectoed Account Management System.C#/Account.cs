using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refectoed_Account_Management_System.C_
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
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
                Console.WriteLine("Insufficient funds");
            }
        }
        public int getAccountId() 
        { 
            return AccountId; 
        }
        public string getAccountHolder() 
        {
            return AccountHolder;
        }
    }
}
