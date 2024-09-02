namespace OOP_1
{
    internal class Para
    {
        public double First { get; set; }
        public double Second { get; set; }
        public double Sum() => First + Second;
        public double Max() => (First > Second) ? First : Second;

    }
}
