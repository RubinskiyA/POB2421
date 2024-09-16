using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5_3.Model
{
    public partial class Person
    {
        public partial void Read()
        {
            MessageBox.Show("I'm reading");
        }

        public void Move()
        {
            MessageBox.Show("I'm moving");
        }
    }
}
