using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing
{
    public class Salary_Calculation
    {
        double hra;
        double ta;
        double da;
        double tax;
        public double netSalary;
        public void CalculateSalary(double salary)
        {
            if (salary <= 10000)
            {
                hra = salary * 0.1;
                ta = salary * 0.3;
                da = salary * 0.4;
                tax = salary * 0.2;
                netSalary = salary + hra + ta + da - tax;
                
            }
            else
            {
                hra = salary * 0.2;
                ta = salary * 0.3;
                da = salary * 0.4;
                tax = salary * 0.4;
                netSalary = salary + hra + ta + da - tax;
                
            }
        }
        public double CalculateSalary1(double hourlyRate, double hoursWorked)
        {
            if (hoursWorked <= 0)
            {
                throw new ArgumentException("Hours worked cannot be less than 0");
            }
            return hoursWorked * hourlyRate;
        }
    }
}
