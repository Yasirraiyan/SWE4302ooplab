using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Refectoed_Account_Management_System.C_
{
   public  interface IAccountRepository
    {
        void AddAccount(Account account);
        Account GetAccount(int accountId);
        IEnumerable<Account> GetAllAccounts();
    }
}
