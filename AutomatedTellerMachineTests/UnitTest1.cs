using System;
using Xunit;
using UnitTesting;
using static UnitTesting.Program;

namespace AutomatedTellerMachineTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnBalance()
        {
            Assert.Equal(balance, GetBalance());
        }

        [Theory]
        [InlineData(50)]
        [InlineData(1000)]
        public void CanDepositMoney(decimal money)
        {
            Assert.Equal(balance + money, Deposit(money));
        }

        [Theory]
        [InlineData(50)]
        [InlineData(1000)]
        public void CanWithdrawMoney(decimal money)
        {
            Assert.Equal(balance - money, Withdraw(money));
        }
    }
}
