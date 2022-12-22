using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Command
    {
        public class Account_NonCommand
        {
            public string OwnerName { get; set; }
            public decimal Balance { get; set; }

            public Account_NonCommand(string ownerName, decimal balance)
            {
                OwnerName = ownerName;
                Balance = balance;
            }

            public void Deposit(decimal amount)
            {
                Balance += amount;
            }

            public void Withdraw(decimal amount)
            {
                if (amount > Balance)
                {
                    throw new ArgumentOutOfRangeException("Overdraft error");
                }

                Balance -= amount;
            }
        }
    }
}
