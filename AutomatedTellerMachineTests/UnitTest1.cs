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

        [Fact]
        public void CannotBeZero()
        {
            Assert.NotEqual(0, GetBalance());
        }

        [Fact]
        public void CanDepositMoney()
        {
            Assert.Equal(balance + 50m, Deposit(50m));
        }

        [Fact]
        public void CanWithdrawMoney()
        {
            Assert.Equal(balance - 50m, Withdraw(50m));
        }

        [Theory]
        [InlineData(50)]
        [InlineData(1000)]
        public void CanDepositDifferentAmounts(decimal money)
        {
            Assert.Equal(balance + money, Deposit(money));
        }

        [Theory]
        [InlineData(50)]
        [InlineData(1000)]
        public void CanWithdrawDifferentAmounts(decimal money)
        {
            Assert.Equal(balance - money, Withdraw(money));
        }
    }
}
