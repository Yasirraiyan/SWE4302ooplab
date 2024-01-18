using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refectoed_Account_Management_System.C_
{
    public class AccountRepository : IAccountRepository
    {

    
    private List<Account> accounts = new List<Account>();

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public Account GetAccount(int accountId)
    {
        return accounts.Find(a => a.AccountId == accountId);
    }

    public IEnumerable<Account> GetAllAccounts()
    {
        return accounts;
    }
}
}
