namespace Single_Responsibility_Principle.SRP_Classes
{
    public class EmailSender : EmployeeSRP
    {
        string _mail;
        //This class belongs to only sending emails to the employees
        //In this class every methods, properties purpose is to sending mail only.
        public void SendEmail()
        {
            _mail = Email;
        }
    }
}
