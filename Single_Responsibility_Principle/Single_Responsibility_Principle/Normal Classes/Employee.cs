namespace Single_Responsibility_Principle
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string? FirstName { get; set; }
        public String? LastName { get; set; }
        public long MobileNumber { get; set; }
        public string? Email { get; set; }
        public double Salary { get; set; }

        public void AddEmployee()
        {
            //we can add Employee From here
        }
        public void DeleteEmployee()
        {
            //We can delete employee from here
        }
        public void CalculateSalary()//it comes under different responsibility //Category
        {
            //we can calculate salary from here
        }
        public void SendEmail()//it comes under different responsibility
        {
            //we can send mails from here
        }
    }
}
