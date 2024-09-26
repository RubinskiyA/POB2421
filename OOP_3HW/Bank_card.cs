using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3HW
{
    internal class Bank_card
    {
        private long cardId;
        public long CardId
        {
            get { return cardId; }
            set { if (value > 0) cardId = value; }
        }
        public string? Name {  get; set; }
        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { if (value > 0) amount = value; }
        }

        public Bank_card(long cardId, string? name, decimal amount)
        {
            this.cardId = cardId;
            Name = name;
            this.amount = amount;
        }
        public void AddAmount(decimal sum)
        {
            this.amount += sum;
            Console.WriteLine($"Теперь на вашем счете: {amount}");
        }
        public void SubAmount(decimal sub)
        {
           
            if (amount > sub) { this.amount -= sub; Console.WriteLine($"Теперь на вашем счете: {amount}"); }
            else Console.WriteLine("Недостаточно средств");
        }
        public void Print()
        {
            Console.WriteLine($"На вашем счете: {amount}");
        }


    }
}
