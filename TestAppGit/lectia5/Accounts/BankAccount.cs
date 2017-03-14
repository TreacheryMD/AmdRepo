using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    public abstract class BankAccount
    {
        public string Client { get; set; }
        public string AccNum { get; set; }
        public decimal Balance { get; set; }
        public DateTime OpenDate { get; set; }
        public string Currency { get; set; }

        public BankAccount() { }

        public virtual void ShowAccountInfo()
        {
            Console.Write($"Client: {Client} | AccountNumber:{AccNum} | Balance:{Balance} | Open: {OpenDate.ToShortDateString()} | Currency: {Currency}");
        }

        public static void ShowAccountInfo(IEnumerable<BankAccount> yourEnum)
        {
            foreach (var item in yourEnum)
            {
                item.ShowAccountInfo();
            }
        }
        public BankAccount(string owner, decimal balance, string accountNumber, DateTime openDate, string currency)
        {
            while (string.IsNullOrWhiteSpace(owner))
            {
                Console.WriteLine("Client format is incorect,enter new Client:");
                Client = owner = Console.ReadLine();
            }

            AccNum = accountNumber;
            Balance = balance;
            Client = owner;
            OpenDate = openDate;
            Currency = currency;
        }
    }
}
