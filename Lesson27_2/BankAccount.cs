using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27_2
{
    internal class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        {
            this.balance = balance;
        }
        // Метод для пополнения счета
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Пополнено на {amount:C}. Новый баланс: {balance:C}");
            }
            else
            {
                Console.WriteLine("Сумма пополнения должна быть положительной.");
            }
        }

        // Метод для снятия денег со счета
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Снято {amount:C}. Новый баланс: {balance:C}");
                }
                else
                {
                    Console.WriteLine("Недостаточно средств на счете.");
                }
            }
            else
            {
                Console.WriteLine("Сумма снятия должна быть положительной.");
            }
        }

        // Метод для проверки баланса
        public decimal GetBalance()
        {
            return balance;
        }

        // Метод для отображения информации о счете
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Текущий баланс: {balance:C}");
        }
    }
}
