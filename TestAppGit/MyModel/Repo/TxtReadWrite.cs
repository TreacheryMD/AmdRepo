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

                    if (type.Replace(" ","") == "CurrentAccount")
                    {
                        var l = line.Replace("Type:CurrentAccount", "").Split('|');
                        var client = l[0].Replace("Client:","");
                        var accountNum = l[1].Replace(" AccountNumber:","");
                        var balance = Convert.ToDecimal(l[2].Replace(" Balance:",""));
                        var date = DateTime.Parse(l[3].Replace("Open:", "").Replace(" ", ""));
                        var currency = l[4].Replace(" Currency: ","");
                        var restricted = l[5].Contains("True")? true : false;

                        list.Add(new CurrentAccount(client,balance,accountNum, date, currency, restricted));
                    }
                }
            }
            return list;
        }
    }
}
