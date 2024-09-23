namespace HWIndexator
{
    internal class BaseClass
    {
        public int Number { get; set; }
        public int this[int index]
        {
            get
            {
                string strNumber = Number.ToString();
                return int.Parse(strNumber[index].ToString());
            }


        }
    }
}
