using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6_Praktic_
{
    internal class Student
    {
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }
        public string? Group {  get; set; }
        private double averageMark;
        public double AverageMark
        {
            get { return averageMark; }
            set { if(value>0) averageMark = value; }
        }
        public double getScholarShip()
        {
            if (averageMark == 5) return 5000;
            else return 3000;
        }
    }
}
