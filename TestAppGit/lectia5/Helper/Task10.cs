using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5.Helper
{
    delegate bool IsRestrictable(CurrentAccount crAccount);
    class Task10
    {
        public static void RestrictAccountHardCoded(List<CurrentAccount> accounts)
        {
            foreach (var acc in accounts)
            {
                if (acc.Balance > 600000)
                {
                    acc.Restricted = true;
                }
            }
        }

        public static void FixRestrictAccount(List<CurrentAccount> accounts, IsRestrictable isRestrictable)
        {
            foreach (var acc in accounts)
            {
                if (isRestrictable(acc)) // now logic will be decided by end User who will use this method
                {
                    acc.Restricted = true;
                }
            }
        }

        public static void SecondFixUnrestrict(List<CurrentAccount> accounts, Func<CurrentAccount, bool> isUnRestrictable) //no more need to declare delegate
        {
            foreach (var acc in accounts)
            {
                if (isUnRestrictable(acc)) // now logic will be decided by end User who will use this method
                {
                    acc.Restricted = false;
                }
            }
        }

        public static bool Restrict(CurrentAccount crAcc) //user methed
        {
            return crAcc.Balance > 0 ? true : false;
        }


    }
}
