using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class BankAccount
    {
        private int _accountNumber;
        private decimal balance;
        private BankAccountType type;
        public BankAccount(decimal balance, BankAccountType type)
        {
            _accountNumber = GenerateAccountNumber();
            this.balance = balance;
            this.type = type;
        }
        public void Print()
        {
            Console.WriteLine($"Номер счета: {GenerateAccountNumber()}\nБаланс: {balance} руб.\nТип счета: {type}");
        }

        private static int lastAccountNumber = 0;
        private static int GenerateAccountNumber()
        {
            lastAccountNumber++;
            return lastAccountNumber;
        }

        public int GetAccountNumber()
        {
            return _accountNumber;
        }

        public void Deposit(decimal amount, decimal balance)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Внесено на счет: {amount} руб. Баланс после операций: {balance} руб.\n");
            }
            else
            {
                Console.WriteLine("Нельзя внести отрицательную сумму!");
            }

        }
        public void Withdraw(decimal amount, decimal balance)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Снято со счета: {amount} руб. Баланс после операций: {balance} руб.\n");
            }
            else
            {
                Console.WriteLine($"Невозможно снять сумму, недостаточно средств на счете! Баланс: {balance}\n");
            }
        }
        public void Transfer(BankAccount reciever, int sum)
        {
            if (sum < 0)
            {
                throw new ArgumentException("Сумма перевода не может быть отрицательной");
            }
            if (balance < sum)
            {
                throw new InvalidOperationException("На счете недостаточно средств!");
            }
            Withdraw(sum, balance);
            reciever.Deposit(sum, balance);
        }
    }
}

