﻿namespace BubleSort
{
    internal class Person
    {
        public string? Name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set { if (value > 0) age = value; }
        }
    }
}
