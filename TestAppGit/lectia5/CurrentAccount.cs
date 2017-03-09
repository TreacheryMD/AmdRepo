using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class CurrentAccount : BankAccount,ITransferable
    {
        public bool Restricted { get; set; }

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
            if (cashInAmmout<=0)
            {
                throw new Exception("You can't Cash In nothing to your current account");
            }
            this.Balance += cashInAmmout;
        }
        public void CashOut(decimal cashOutAmmount)
        {
            if (Restricted == false)
            {
                if (cashOutAmmount <= 0)
                {
                    throw new Exception("You can't Cash Out with negative ammount");
                }
                this.Balance -= cashOutAmmount;
            }
            else throw new AccountIsRestrictedException();
        }

        public void Transfer(BankAccount targetAcc,decimal ammount)
        {
            if (Restricted == false)
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
            else
            {
                throw new AccountIsRestrictedException();
            }
           
        }

    }
}
