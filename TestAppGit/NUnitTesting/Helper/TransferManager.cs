using System;
using NUnitTesting.Accounts;
using NUnitTesting.Interfaces;

namespace NUnitTesting.Helper
{
    public class TransferManager
    {
        private readonly ICursManager _cursManager;
        private readonly IRepository<Transaction> _transactionRepository;
      

        public TransferManager(ICursManager cursManager, IRepository<Transaction> transactionRepository)
        {
            _cursManager = cursManager;
            _transactionRepository = transactionRepository;
        }

        public void ExecuteTransfer(BankAccount sourceBankAccount, BankAccount targetBankAccount, decimal ammount)
        {
            if (sourceBankAccount.GetType().ToString().Contains("CreditAccount")) throw new Exception("source can not be CreditAccount");
            var convertAmount = _cursManager.CurrencyConvert(sourceBankAccount.Currency, targetBankAccount.Currency, ammount);
            if (CanTransfer(sourceBankAccount, ammount))
            {
                sourceBankAccount.OutBalance(ammount);
                targetBankAccount.InBalance(convertAmount);
                //_transactionRepository.Add(new Transaction(sourceBankAccount, targetBankAccount, ammount));
            }
            else
            {
                throw new Exception("Not enought money on source account");
            }
            
        }
        private bool CanTransfer(BankAccount acc1, decimal amount) => acc1.Balance >= amount;
    }

}

