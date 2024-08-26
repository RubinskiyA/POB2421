namespace PolyaKlassa
{
    internal class Employee
    {
        public static int count = 0;
        private const int month = 12;
        public readonly int maxYear = 150;
        private string? name;
        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 150) age = value;
            }
        }
        private double salary;
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0) salary = value;
            }
        }
        public double getSalaryByYear()
        {
            return salary * month;
        }
    }
}
