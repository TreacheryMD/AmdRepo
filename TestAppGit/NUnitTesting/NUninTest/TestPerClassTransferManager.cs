using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using NUnitTesting.Accounts;
using NUnitTesting.Helper;
using NUnitTesting.Interfaces;

namespace NUnitTesting.NUninTest
{

    [TestFixture]
    class TestPerClassTransferManager
    {
        private Mock<ICursManager> _cursManagerMock;
        private Mock<IRepository<Transaction>> _transactionMock;
        private TransferManager _transferManager;
        
        [SetUp]
        public void Setup()
        {
            _cursManagerMock = new Mock<ICursManager>();
            _cursManagerMock.Setup(m => m.CurrencyConvert(CurrencyTypes.MDL, CurrencyTypes.MDL,500)).Returns(500);
            _transactionMock = new Mock<IRepository<Transaction>>();
            _transactionMock.Setup(s => s.Add(new Transaction(new CurrentAccount(), new CurrentAccount(), 0)));
            _transferManager = new TransferManager(_cursManagerMock.Object, _transactionMock.Object);
        }

        [Test]
        public void ExecuteTransferForCurrentAccount()
        {
            var sourceCurrentAccount = new CurrentAccount();
            var targetCurrentAccount = new CurrentAccount();
            
            sourceCurrentAccount.InBalance(1000);
            _transferManager.ExecuteTransfer(sourceCurrentAccount, targetCurrentAccount, 500);

            Assert.AreEqual(500, targetCurrentAccount.Balance);
            Assert.AreEqual(500, sourceCurrentAccount.Balance);
        }
    }
}
