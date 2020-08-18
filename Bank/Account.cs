using System;

namespace Bank
{
    public class Account
    {
        public int Balance { get; private set; }

        public Account(int balance = 0)
        {
            Balance = balance;
        }

        public void Tranfer(int value, Account to)
        {
            if(Balance - value < 0)
            {
                throw new Exception("Not enough funds");
            }
            to.Balance += value;
            Balance -= value;
        }
    }
}
