namespace HWIndexator
{
    internal class ChildClass : BaseClass
    {
        public int Second { get; set; }

        public override int this[int index] => base[index];
    }
}
