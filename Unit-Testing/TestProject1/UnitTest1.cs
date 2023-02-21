using Microsoft.VisualStudio.TestPlatform.TestHost;
using Unit_Testing;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var hello = new HelloWorld();
            //Act
            var result = hello.Method1();
            //Assert
            Assert.Equal("Hello World", result);
        }
        [Fact]
        public void Test2()
        {
            //Arrange
            var obj = new HelloWorld();
            var a = 5;
            var b = 3;
            var expectedResult = 8;
            //Act
            var result = obj.MethodInte(a, b);
            //Assertt
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Task_Mul()
        {
            //Arrange
            var obj = new HelloWorld();
            int a = 2;
            int b = 11;
            var expectedValue = 22;
            //Act
            var result = obj.Mul(a, b);
            //Assert
            Assert.Equal(expectedValue, result);
        }
        [Fact]
        public void Task_Salary()
        {
            //Arrange
            double salary = 10000;
            var obj = new Salary_Calculation();
            var expectedSalary = 15999;
            //Act
            obj.CalculateSalary(salary);
            var result = obj.netSalary;
            //asert
            Assert.Equal(expectedSalary, result);
        }
        [Fact]
        public void TestCalculateSalaryMethodExceptionWhenWorkHourIsZero()
        {
            var obj = new Salary_Calculation();
            double hourlyRate = 100;
            double hoursWorked = 0;
           
            var result = Assert.Throws<ArgumentException>(() => obj.CalculateSalary1(hourlyRate,hoursWorked));
            Assert.Equal("Hours worked cannot be less than 0", result.Message);
        }
    }
}

//using System;
//using Xunit;

//namespace MyProject.Tests
//{
//    public class SalaryCalculatorTests
//    {
//        [Fact]
//        public void TestCalculateSalaryMethod_ThrowsExceptionForNegativeHoursWorked()
//        {
//            // Arrange
//            var salaryCalculator = new SalaryCalculator();
//            var hourlyRate = 20;
//            var hoursWorked = -10;

//            // Act & Assert
//            var exception = Assert.Throws<ArgumentException>(() => salaryCalculator.CalculateSalary(hourlyRate, hoursWorked));
//            Assert.Equal("Hours worked cannot be less than 0.", exception.Message);
//        }
//    }

//    public class SalaryCalculator
//    {
//        public int CalculateSalary(int hourlyRate, int hoursWorked)
//        {
//            if (hoursWorked < 0)
//            {
//                throw new ArgumentException("Hours worked cannot be less than 0.");
//            }
//            return hourlyRate * hoursWorked;
//        }
//    }
//}
