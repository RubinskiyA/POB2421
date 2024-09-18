using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6_Nasledovanie_
{
    internal class Employee:Person
    {
        public Employee()
        {

        }

        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }

        public string Company { get; set; } = "";
       public new void Print()
        {
            Console.WriteLine("Menya zovut: " + Name+" Ya rabotayu v: "+Company);
        }
    }
}