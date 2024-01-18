using Refectoed_Account_Management_System.C_;
using System.Security.Principal;

namespace Refectoed_Account_Management_System.C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();

            // Set some initial values
            myAccount.AccountId = 123;
            myAccount.AccountHolder = "John Doe";
            myAccount.Balance = 1000.00m;

            // Display initial account information
            Console.WriteLine("Account ID: " + myAccount.getAccountId());
            Console.WriteLine("Account Holder: " + myAccount.getAccountHolder());
            Console.WriteLine("Balance: $" + myAccount.Balance);

            // Make a deposit
            myAccount.Deposit(500.50m);
            Console.WriteLine("\nAfter deposit of $500.50:");
            Console.WriteLine("Balance: $" + myAccount.Balance);

            // Make a withdrawal
            myAccount.Withdraw(200.75m);
            Console.WriteLine("\nAfter withdrawal of $200.75:");
            Console.WriteLine("Balance: $" + myAccount.Balance);

            // Attempt to withdraw more than the balance
            myAccount.Withdraw(1500.00m);
            Console.WriteLine("Balance: $" + myAccount.Balance);

            // Display final account information
            Console.WriteLine("\nFinal Account Information:");
            Console.WriteLine("Account ID: " + myAccount.getAccountId());
            Console.WriteLine("Account Holder: " + myAccount.getAccountHolder());
            Console.WriteLine("Balance: $" + myAccount.Balance);

            AccountRepository accountRepository = new AccountRepository();

            // Create some accounts
            Account account1 = new Account { AccountId = 1, AccountHolder = "Alice", Balance = 1000.00m };
            Account account2 = new Account { AccountId = 2, AccountHolder = "Bob", Balance = 2000.00m };
            Account account3 = new Account { AccountId = 3, AccountHolder = "Charlie", Balance = 1500.00m };

            // Add accounts to the repository
            accountRepository.AddAccount(account1);
            accountRepository.AddAccount(account2);
            accountRepository.AddAccount(account3);

            // Display all accounts in the repository
            Console.WriteLine("All Accounts in Repository:");
            foreach (var account in accountRepository.GetAllAccounts())
            {
                Console.WriteLine($"Account ID: {account.AccountId}, Account Holder: {account.AccountHolder}, Balance: {account.Balance:C}");
            }

            // Get a specific account by ID
            int accountIdToGet = 2;
            Account retrievedAccount = accountRepository.GetAccount(accountIdToGet);

            if (retrievedAccount != null)
            {
                Console.WriteLine($"\nRetrieved Account with ID {accountIdToGet}:");
                Console.WriteLine($"Account ID: {retrievedAccount.AccountId}, Account Holder: {retrievedAccount.AccountHolder}, Balance: {retrievedAccount.Balance:C}");
            }
            else
            {
                Console.WriteLine($"\nAccount with ID {accountIdToGet} not found.");
            }

            BankService bankService = new BankService(accountRepository);

            // Perform a transfer from account1 to account2
            int fromAccountId = 1;
            int toAccountId = 2;
            decimal transferAmount = 500.00m;

            Console.WriteLine($"\nTransferring ${transferAmount} from Account ID {fromAccountId} to Account ID {toAccountId}...");

            // Call the Transfer method in BankService
            bankService.Transfer(fromAccountId, toAccountId, transferAmount);

            // Display updated account information after transfer
            Console.WriteLine("\nUpdated Account Information:");
            foreach (var account in accountRepository.GetAllAccounts())
            {
                Console.WriteLine($"Account ID: {account.AccountId}, Account Holder: {account.AccountHolder}, Balance: {account.Balance:C}");
            }
        }
    }

}
    



