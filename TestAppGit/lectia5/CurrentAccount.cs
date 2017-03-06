using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class CurrentAccount : BankAccount,ITransferable
    {
        public CurrentAccount(string owner, decimal balance, string accountNumber) : base(owner, balance, accountNumber+"CR")
        {
        }

        public override void ShowAccountInfo()
        {
            Console.WriteLine("Curent account:");
            base.ShowAccountInfo();
        }

        public void CashIn(decimal cashInAmmout)
        {
            this.Balance += cashInAmmout;
        }
        public void CashOut(decimal cashOutAmmount)
        {
            this.Balance -= cashOutAmmount;
        }

        public void Transfer(BankAccount targetAcc,decimal ammount)
        {
            if (targetAcc is DepositAccount)
            {
                this.Balance -= ammount;
                targetAcc.Balance += ammount;
            }
            else
            {
                this.Balance -= ammount;
                targetAcc.Balance -= ammount;
            }
        }

    }
}
