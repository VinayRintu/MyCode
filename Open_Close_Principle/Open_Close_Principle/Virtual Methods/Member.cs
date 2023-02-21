namespace Open_Close_Principle.Virtual_Methods
{
    public class Member
    {
       public virtual double GetDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }

    public class ImpMember : Member 
    {
        public override double GetDiscount(double TotalSales)
        {
            return base.GetDiscount(TotalSales) - 50;
        }
    }

    public class VImpMember : Member
    {
        public override double GetDiscount(double TotalSales)
        {
            return base.GetDiscount(TotalSales) - 200;
        }
    }
    public class NormalMember : Member
    {
        public override double GetDiscount(double TotalSales)
        {
            return base.GetDiscount(TotalSales);
        }
    }
}
