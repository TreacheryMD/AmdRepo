using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class TransferMoney
    {
        public static void Transfer(CurrentAccount fromCurrentAcc,CreditAccount toCreditAcc, decimal ammount)
        {
            if (fromCurrentAcc.Restricted) throw new AccountIsRestrictedException();
            fromCurrentAcc.Balance -= ammount;
            toCreditAcc.Balance -= ammount;   
        }
        public static void Transfer(CurrentAccount fromCurrentAcc, DepositAccount toDepositAcc, decimal ammount)
        {
            if (fromCurrentAcc.Restricted) throw new AccountIsRestrictedException();
            fromCurrentAcc.Balance -= ammount;
            toDepositAcc.Balance += ammount;
        }
        public static void Transfer(CurrentAccount fromCurrentAcc, InterestAccount toInterestAcc, decimal ammount)
        {
            if (fromCurrentAcc.Restricted) throw new AccountIsRestrictedException();
            fromCurrentAcc.Balance -= ammount;
            toInterestAcc.Balance += ammount;
        }
    }

}
