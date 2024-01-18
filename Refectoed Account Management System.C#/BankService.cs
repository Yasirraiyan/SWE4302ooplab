using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refectoed_Account_Management_System.C_
{
    public class BankService
    {
        private readonly IAccountRepository accountRepository;

        public BankService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public void Transfer(int fromAccountId, int toAccountId, decimal amount)
        {
            var fromAccount = accountRepository.GetAccount(fromAccountId);
            var toAccount = accountRepository.GetAccount(toAccountId);

            if (fromAccount != null && toAccount != null)
            {
                fromAccount.Withdraw(amount);
                toAccount.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Invalid account IDs");
            }
        }
    }
}
