namespace Open_Close_Principle.Normal_Methods
{
    public class MemberNormal
    {
       public int MemberType { get; set; }
        public double GetDiscount(double TotalDiscount)
        {
            if (MemberType == 1)
            {
                return TotalDiscount - 100;
            }
            else
            {
                return TotalDiscount - 50;
            }
        }
        public void add()
        {

        }
    }
}
