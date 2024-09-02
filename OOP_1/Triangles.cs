namespace OOP_1
{
    internal class Triangles
    {
        private double a;
        public double A { get { return a; } set { if (value > 0 && Valide(value, B, C)) a = value; } }
        private double b;
        public double B { get { return b; } set { if (value > 0 && Valide(A, value, C)) b = value; } }
        private double c;



        public double C { get { return c; } set { if (value > 0 && Valide(A, B, value)) c = value; } }
        public Triangles(double _a, double _b, double _c)
        {
            if (Valide(_a, _b, _c))
            {
                A = _a;
                B = _b;
                C = _c;
            }
        }
        public bool Valide(double _a, double _b, double _c)
        {
            if (_a + _b > _c && _a + _c > _b && _b + _c > _a)
            {
                return true;
            }
            return false;
        }
        public double Perimetr()
        {
            return a + b + c;
        }
        public double Area()
        {
            double pp = Perimetr() / 2;
            return Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
        }
        public void Print()
        {
            Console.WriteLine("Периметр " + Perimetr() + ", площадь " + Area());
        }

    }

}
