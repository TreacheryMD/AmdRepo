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
                    writer.WriteLine(account + $" Type: {account.GetType().ToString().Split('.').Last()}");
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

                    var type = line.Split(new string[] {"Type:"}, StringSplitOptions.None).Last();
                    var l = line.Replace($"Type:{type}", "").Split('|');
                    var client = l[0].Replace("Client:", "");
                    var accountNum = l[1].Replace(" AccountNumber:", "");
                    var balance = Convert.ToDecimal(l[2].Replace(" Balance:", ""));
                    var date = DateTime.Parse(l[3].Replace("Open:", "").Replace(" ", ""));
                    var currency = l[4].Replace(" Currency: ", "");

                    if (type.Replace(" ","") == "CurrentAccount")
                    {
                        var restricted = l[5].Contains("True");
                        list.Add(new CurrentAccount(client,balance,accountNum.Replace("CR",""), date, currency, restricted));
                    }
                    else if (type.Replace(" ", "") == "CreditAccount")
                    {
                        list.Add(new CreditAccount(new CurrentAccount(client, balance, accountNum.Replace("CRED",""), date, currency), balance, date,
                            currency));
                    }
                    else if (type.Replace(" ", "") == "DepositAccount")
                    {
                        var interestRate = Convert.ToDouble(l.Last().Replace("Interest Rate:","").Replace(" ",""));
                        list.Add(new DepositAccount(new CurrentAccount(client,balance,accountNum.Replace("DEP", ""), date,currency),balance, interestRate,date,currency));
                    }
                    else if (type.Replace(" ", "") == "InterestAccount")
                    {
                        var interestRate = Convert.ToDouble(l[5].Replace("Interest Rate:", "").Replace(" ", ""));
                        var mPay = Convert.ToDecimal(l[6].Replace("MonthlyPay:", "").Replace(" ", ""));

                        list.Add(new InterestAccount(new CurrentAccount(client, balance, accountNum.Replace("INT", ""), date, currency),balance,interestRate,mPay,date,currency));
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
