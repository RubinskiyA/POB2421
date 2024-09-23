namespace OOP_7_Practik
{
    internal class Train
    {
        private int number;
        public int Number
        {
            get { return number; }
            set { if (value > 0) number = value; }
        }
        public string? Destination { get; set; }

        public TimeOnly? TimeArrival { get; set; }
        public TimeOnly? TimeDeparture { get; set; }

    }
}
