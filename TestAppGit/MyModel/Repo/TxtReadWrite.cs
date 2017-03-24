using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Accounts;
using MyModel.Interfaces;

namespace MyModel.Repo
{
    class TxtReadWrite
    {
        public  static void WriteToTxt(List<BankAccount> list)
        {
            using (StreamWriter writer = new StreamWriter(Path.GetFullPath(@"Storage\storage.txt")))
            {
                foreach (BankAccount account in list)
                {
                    writer.WriteLine(account + $";{account.GetType().ToString().Split('.').Last()}");
                }
            }
        }
        public static List<BankAccount> ReadFromTxt()
        {
            List<BankAccount> list = new List<BankAccount>();

            using (StreamReader reader = new StreamReader(Path.GetFullPath(@"Storage\storage.txt")))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var type = line.Split(';').Last();
                    if (type.Contains("CurrentAccount"))
                    {
                        list.Add(new CurrentAccount(line));
                    }
                    else if (type.Contains("CreditAccount"))
                    {
                        list.Add(new CreditAccount(line));
                    }
                    else if (type.Contains("DepositAccount"))
                    {
                      list.Add(new DepositAccount(line));
                    }
                    else if (type.Contains("InterestAccount"))
                    {
                      list.Add(new InterestAccount(line));
                    }
                    else
                    {
                        throw new Exception("There is no type, something gone wrong");
                    }
                }
            }
            return list;
        }
    }
}
