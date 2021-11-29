using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Danushka",10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
            account.MakeWithdrawal(120, DateTime.Now,"Hammock");
            account.MakeWithdrawal(720, DateTime.Now, "XBOX");
            Console.WriteLine(account.GetAccountHistory());
        }
    }


}