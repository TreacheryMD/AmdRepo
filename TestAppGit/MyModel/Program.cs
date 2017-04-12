using MyModel.Accounts;
using MyModel.Extension;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Clients;
using MyModel.Interfaces;
//using IronPython.Hosting;
using MyModel.Repo;
using MyModel.Testing_proxy;
using System.IO;
using MyModel.Helper;
using System.Data.SqlClient;
using System.Data.Common;

namespace MyModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ion", "Draganel", new DateTime(1991, 06, 10), "20050013346680", GenderType.Male);
            Person person2 = new Person();

            BankAccount acc1 = new CurrentAccount(person1,1100,"454654646545",DateTime.Now, CurrencyTypes.MDL);
            BankAccount acc2 = new CreditAccount(person1, "454444454666",0,DateTime.Now, CurrencyTypes.MDL, new DateTime(2018, 01, 01));
            BankAccount acc3 = new DepositAccount(person2, "3495782094785",40000,2.4,DateTime.Now, CurrencyTypes.MDL);

            IServiceLocator locator = new ServiceLocator();
            var myservice = locator.GetService<IRepository<Transaction>>();

            TransferManager transferHandler = new TransferManager(myservice);
            transferHandler.ExecuteTransfer(acc1, acc3,1000);
            Console.WriteLine(acc1);
            Console.WriteLine(acc3);

            #region WriteReadTxt

            //List<BankAccount> allAcc = new List<BankAccount>() { acc1, acc2, acc3 };
            //IRepository<BankAccount> txtRep = new TxTBankAccRepository();
            //txtRep.Add(allAcc);
            //var test = txtRep.GetAll();

            #endregion

            #region ADO.NET task
            
            //SQL_Helper sqlHelper = new SQL_Helper();
            
            ////T1-T2
            //string script = File.ReadAllText(@"CREATE_TEST_TABLES.sql");
            //sqlHelper.connStrName = "TestBankAccounts";
            ////sqlHelper.CreateCommand(script);
            ////T3
            //DataSet dataSet = new DataSet();
            //using (var conn = new SqlConnection(sqlHelper.ConnStr))
            //{
            //    conn.Open();
            //    SqlDataAdapter adapter = new SqlDataAdapter();

            //    // Create the SelectCommand.
            //    SqlCommand command = new SqlCommand("SELECT * FROM [tblCreditAccounts] WHERE Balance > @Balance", conn);
            //    command.Parameters.AddWithValue("@Balance", 30000);
            //    adapter.SelectCommand = command;

            //    //adapter.Fill(dataSet);

            //    //Create the InsertCommand.

            //    command = new SqlCommand(
            //       "INSERT [dbo].[tblCreditAccounts] ( AccNum, Balance, OpenDate, Currency, FiscalCode, Reimbursement)" +
            //       "VALUES (@AccNum, @Balance, @OpenDate, @Currency, @FiscalCode, @Reimbursement)", conn);

            //    // Add the parameters for the InsertCommand.
            //    command.Parameters.Add("@AccNum", SqlDbType.VarChar).Value = "9999999999CRED";
            //    command.Parameters.Add("@Balance", SqlDbType.Decimal).Value = 800000;
            //    command.Parameters.Add("@OpenDate", SqlDbType.Date).Value = "2017-01-01";
            //    command.Parameters.Add("@Currency", SqlDbType.Int).Value = 978;
            //    command.Parameters.Add("@FiscalCode", SqlDbType.VarChar).Value = "3479853467985";
            //    command.Parameters.Add("@Reimbursement", SqlDbType.Date).Value = "2017-02-02";
            //    adapter.InsertCommand = command;

            //    //adapter.InsertCommand.ExecuteNonQuery();


            //    //Create the UpdateCommand
            //    command = new SqlCommand(
            //      "UPDATE [dbo].[tblCreditAccounts] SET Balance = 0 WHERE Balance < @Balance", conn);
            //    command.Parameters.Add("@Balance", SqlDbType.Decimal).Value = 20000;
            //    adapter.UpdateCommand = command;

            //    //adapter.UpdateCommand.ExecuteNonQuery();

            //    //create the Delete Command 
            //    command = new SqlCommand(
            //          "DELETE [dbo].[tblCreditAccounts] AccNum = @AccNum", conn);
            //    command.Parameters.Add("@AccNum", SqlDbType.VarChar).Value = "9999999999CRED";
            //    adapter.DeleteCommand = command;

            //    //adapter.DeleteCommand.ExecuteNonQuery();


            //    //T4

            //    DataTable anonimBalanceCred = new DataTable();
            //    anonimBalanceCred.Columns.Add("Balance", typeof(decimal));
            //    anonimBalanceCred.Columns.Add("Currency", typeof(Int16));
            //    anonimBalanceCred.Columns.Add("OpenDate", typeof(DateTime));
            //    anonimBalanceCred.Columns.Add("Reimbursement", typeof(DateTime));

   
            //}





            #endregion


            Console.ReadLine();


        }
    }
}
