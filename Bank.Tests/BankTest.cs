using System;
using Xunit;

namespace Bank.Tests
{
    public class BankTest
    {
        [Fact]
        public void Can_initiate_account_with_money()
        {
            var from = new Account(100);
            Assert.Equal(100, from.Balance);
        }

        [Fact]
        public void Can_transfer_money()
        {
            var from = new Account(100);
            var to = new Account();

            from.Tranfer(10, to);

            Assert.Equal(10, to.Balance);
        }

        [Fact]
        public void When_transfering_money__account_from_decreases_the_balance()
        {
            var from = new Account(100);
            var to = new Account();

            from.Tranfer(10, to);

            Assert.Equal(90, from.Balance);
        }

        [Fact]
        public void Can_transfer_money_twice()
        {
            var from = new Account(100);
            var to = new Account();

            from.Tranfer(10, to);
            from.Tranfer(10, to);

            Assert.Equal(80, from.Balance);
            Assert.Equal(20, to.Balance);
        }

        [Fact]
        public void Should_not_transfer_money_you_dont_have()
        {
            var from = new Account(10);
            var to = new Account();

            Assert.Throws<Exception>(() => from.Tranfer(20, to));
        }
    }
}
