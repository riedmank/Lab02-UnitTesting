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
    }
}
