
using Xunit;
using Console_UnitTesting;

namespace XunitTesting_Sample
{
    public class UnitTest1
    {
        [Fact]
        public static void Task_Add()
        {
            //Arrange
            var num1 = 2.5;
            var num2 = 3.6;
            var expectedValue = 6.1;

            //Act
            var sum = Calculatioins.Add(num1, num2);

            //Assert
            Assert.Equal(expectedValue, sum,1);
        }
        [Fact]
        public void Task_Mul()
        {
            //Arrange
            var num1 = 2;
            var num2 = 3;
            var expectedValue = 6;

            //Act
            var mul=Calculatioins.Mul(num1, num2);

            //Assert
            Assert.Equal(expectedValue, mul,1);
        }
        [Fact]
        public void Task_Div()
        {
            //Arrange
            var num1 = 5;
            var num2 = 2;
            var expectedValue = 2.5;

            //Act
            var div=Calculatioins.Div(num1, num2);

            //Assert
            Assert.Equal(expectedValue, div,1);
        }
    }
}
