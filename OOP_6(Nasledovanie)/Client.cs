using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6_Nasledovanie_
{
    internal class Client:Person
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }

        public override string? ToString()
        {
            return "Menya zovut:" +Name+"Ya klient banka: "+Bank;
        }
    }
}
