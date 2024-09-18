using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6_Praktic_
{
    internal class Aspirant:Student
    {
        public new double getScholarShip()
        {
            if (AverageMark == 5) return 25000;
            else return 15000;
        }
    }
}
