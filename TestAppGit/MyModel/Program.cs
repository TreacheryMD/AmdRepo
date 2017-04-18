using MyModel.Accounts;
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
using MyModel.NhibernateTry;

namespace MyModel
{
    class Program
    {

        static void Main(string[] args)
        {
            //IoC.RegisterAll();

            //IBankAccountRepository BAccountsRepo = IoC.Resolve<IBankAccountRepository>();
            //IPersonRepository PersonRepo = IoC.Resolve<IPersonRepository>();

            //Person person1 = new Person("Ion", "Draganel", new DateTime(1991, 06, 10), "20050013346680", GenderType.Male);
            //Person person2 = new Person();

            //BankAccount acc1 = new CurrentAccount(person1, 1100, "454654646545", DateTime.Now, CurrencyTypes.MDL);
            //BankAccount acc2 = new CreditAccount(person1, "454444454666", 0, DateTime.Now, CurrencyTypes.MDL, new DateTime(2018, 01, 01));
            //BankAccount acc3 = new DepositAccount(person2, "3495782094785", 40000, 2.4, DateTime.Now, CurrencyTypes.MDL);

            //IServiceLocator locator = new ServiceLocator();
            //var myservice = locator.GetService<IRepository<Transaction>>();

            //TransferManager transferHandler = new TransferManager(myservice);
            //transferHandler.ExecuteTransfer(acc1, acc3, 1000);
            //Console.WriteLine(acc1);
            //Console.WriteLine(acc3);


            ////PersonRepo.Add(person1);
            ////PersonRepo.Add(person2);


            ////BAccountsRepo.Add(acc1);
            ////BAccountsRepo.Add(acc2);
            ////BAccountsRepo.Add(acc3);

            //PersonRepo.Delete(person1);


            #region WriteReadTxt

            //List<BankAccount> allAcc = new List<BankAccount>() { acc1, acc2, acc3 };
            //IRepository<BankAccount> txtRep = new TxTBankAccRepository();
            //txtRep.Add(allAcc);
            //var test = txtRep.GetAll();

            #endregion

            #region ADO.NET task

            SQL_Helper sqlHelper = new SQL_Helper();
            sqlHelper.connStrName = "TestBankAccounts";

            using (var connection = new SqlConnection(sqlHelper.ConnStr))
            {
                connection.Open();

                SqlParameter[] parameters = { new SqlParameter("@Balance", SqlDbType.Decimal)};
                parameters[0].Value = 80000;

                DataTable result = sqlHelper.GetDataTableFromSP("GetAccountsCred", parameters);
            }

            //T1-T2
                string script = File.ReadAllText(@"C:\Users\ion.draganel\Desktop\SQL\CREATE_TEST_TABLES.sql");
            sqlHelper.connStrName = "TestBankAccounts";
            //sqlHelper.CreateCommand(script);
            //T3
            DataSet dataSet = new DataSet();
            var conn = new SqlConnection(sqlHelper.ConnStr);
            // Create the SelectCommand.
            SqlCommand selectCommand = new SqlCommand("GetAccountsCred @Balance", conn);
            selectCommand.Parameters.AddWithValue("@Balance", 80000);
            //adapter.SelectCommand = command;

            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            



            //Create the InsertCommand.

            var insertCommand = new SqlCommand(
               "INSERT [dbo].[tblCreditAccounts] ( AccNum, Balance, OpenDate, Currency, FiscalCode, Reimbursement)" +
               "VALUES (@AccNum, @Balance, @OpenDate, @Currency, @FiscalCode, @Reimbursement)", conn);

            // Add the parameters for the InsertCommand.
            insertCommand.Parameters.Add("@AccNum", SqlDbType.VarChar).Value = "9999999999CRED";
            insertCommand.Parameters.Add("@Balance", SqlDbType.Decimal).Value = 800000;
            insertCommand.Parameters.Add("@OpenDate", SqlDbType.Date).Value = "2017-01-01";
            insertCommand.Parameters.Add("@Currency", SqlDbType.Int).Value = 978;
            insertCommand.Parameters.Add("@FiscalCode", SqlDbType.VarChar).Value = "3479853467985";
            insertCommand.Parameters.Add("@Reimbursement", SqlDbType.Date).Value = "2017-02-02";
            adapter.InsertCommand = insertCommand;

            //adapter.InsertCommand.ExecuteNonQuery()

            //Create the UpdateCommand
            var commandUpdate = new SqlCommand(
              "UPDATE [dbo].[tblCreditAccounts] SET Balance =  @Balance where ID = @Id", conn);
            commandUpdate.Parameters.Add("@Balance", SqlDbType.Decimal, 15, "Balance");
            SqlParameter parm = commandUpdate.Parameters.Add("@Id", SqlDbType.Int, 4, "Id");
            //commandUpdate.Parameters.Add(parm);
            //parm.SourceVersion = DataRowVersion.Original;
            parm.SourceVersion = DataRowVersion.Original;
            adapter.UpdateCommand = commandUpdate;

            //adapter.UpdateCommand.ExecuteNonQuery();

            //create the Delete Command 
            var deleteCommand = new SqlCommand(
                  "DELETE [dbo].[tblCreditAccounts] WHERE AccNum = @AccNum", conn);
            deleteCommand.Parameters.Add("@AccNum", SqlDbType.VarChar).Value = "9999999999CRED";
            adapter.DeleteCommand = deleteCommand;

            adapter.Fill(dataSet);

            dataSet.Tables[0].Rows[0]["Balance"] = 140;

            //adapter.DeleteCommand.ExecuteNonQuery();

            adapter.DeleteCommand.ExecuteNonQuery();
            //adapter.InsertCommand.ExecuteNonQuery();
            //adapter.SelectCommand.ExecuteNonQuery();
            //adapter.UpdateCommanddataSet);

            //adapter.SelectCommand.ExecuteNonQuery();

            adapter.Update(dataSet);

            dataSet.Clear();

            adapter.Fill(dataSet);
            //T4

            //DataTable anonimBalanceCred = new DataTable();
            //anonimBalanceCred.Columns.Add("Balance", typeof(decimal));
            //anonimBalanceCred.Columns.Add("Currency", typeof(Int16));
            //anonimBalanceCred.Columns.Add("OpenDate", typeof(DateTime));
            //anonimBalanceCred.Columns.Add("Reimbursement", typeof(DateTime));


            #endregion



            Console.ReadLine();


        }
    }
}
