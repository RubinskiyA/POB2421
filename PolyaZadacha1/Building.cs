namespace PolyaZadacha1
{
    internal class Building
    {
        Random random = new Random();
        public string? Type { get; set; }//автоматическое свойство
        private double floorHeight;
        public double FloorHeight
        {
            get
            {
                return floorHeight;
            }
            set
            {
                if (value > 0) floorHeight = value;
            }
        }
        private double roofHeight;
        public double RoofHeight
        {
            get
            {
                return roofHeight;
            }
            set
            {
                if (value > 0) roofHeight = value;
            }
        }
        private double length;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0) length = value;
            }
        }
        private double width;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0) width = value;
            }
        }
        private int floorCount;
        public int FloorCount
        {
            get
            {
                return floorCount;
            }
            set
            {
                if (value > 0) floorCount = value;
            }
        }
        private int windowCount;
        public int WindowCount
        {
            get
            {
                return windowCount;
            }
            set
            {
                if (value >= 0) windowCount = value;
            }
        }
        private int roomCount;
        public int RoomCount
        {
            get
            {
                return roomCount;
            }
            set
            {
                if (value > 0) roomCount = value;
            }
        }
        public double CalculateBuildingHeight()
        {
            return floorCount * floorHeight + roofHeight;
        }
        public double CalculateBuildingArea()
        {
            return length * width;
        }
        public int CalculateTotalOpenings()
        {
            return windowCount + roomCount * random.Next(1, 3);
        }
    }

}
