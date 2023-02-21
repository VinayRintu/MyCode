namespace Single_Responsibility_Principle.SRP_Classes
{
    public class Salary : EmployeeSRP
    {
        //It contains only salary calculation part
        // that means All salary calculations like Travel Allowence, TAX, Bonus,etc.. will be done here
        //In this class Every method responsibility is to calculate salary only.
        double _salary;
        public void CalculateSalary()
        {
            _salary = Salary;
            //salary calculation
        }
    }
}
