using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Xml.Linq;
using WebApi_With_Ef_CodeFirst.Controllers;
using WebApi_With_Ef_CodeFirst.Models;
using WebApi_With_Ef_CodeFirst.Repository;

namespace UnitTestProject
{
    public class UnitTestController
    {
        //private List<Employee> employee;
        [Fact]
        public void Test_GetAll_ReturnsCountOfRecords()
        {
            //Arrange
            var mockRepo = new Mock<IDataRepository<Employee>>();
            //var exptData = new List<Employee>();
            //exptData.Add(new Employee()
            //{
            //    EmployeeID = 1,
            //    EmployeeName = "Vinay",
            //    DateOfBirth = new DateTime(2022 - 12 - 27),
            //    PhoneNumber = 9553358351,
            //    Email = "vinay@gmail.com"
            //});
            //exptData.Add(new Employee()
            //{
            //    EmployeeID = 2,
            //    EmployeeName = "Vinay",
            //    DateOfBirth = new DateTime(2022 - 12 - 27),
            //    PhoneNumber = 9553358351,
            //    Email = "vinay@gmail.com"
            //});
            //exptData.Add(new Employee()
            //{
            //    EmployeeID = 3,
            //    EmployeeName = "Vinay",
            //    DateOfBirth = new DateTime(2022 - 12 - 27),
            //    PhoneNumber = 9553358351,
            //    Email = "vinay@gmail.com"
            //});
            var exptData = ExpectEmpData();
            mockRepo.Setup(x => x.GetAll()).Returns(exptData);
            var controller = new EmployeeController(mockRepo.Object);
            //Act
            var result = controller.Get();
            //Assert            
            //var model = Assert.IsAssignableFrom<IEnumerable<Employee>>(result);
            Assert.Equal(3, result.Count());//It verify's if the two objects passed as arguments are equal
        }
        [Fact]
        public void Test_GetAll_ReturnsListOfEmployees()
        {
            //Arrange
            var mockRepo = new Mock<IDataRepository<Employee>>();
            //var exptData = new List<Employee> { new Employee 
            //{ EmployeeID = 1, EmployeeName = "Rintu", DateOfBirth = new DateTime(1999 - 06 - 25), PhoneNumber = 9632587410, Email = "rintu@gmail.com" } };
            var exptData = ExpectEmpData();
            mockRepo.Setup(x => x.GetAll()).Returns(exptData);//this line of code is setting up the mock repository to return the data stored in exptData whenever the GetAll method is called.
            var controller=new EmployeeController(mockRepo.Object);
            //Act
            var result = controller.Get();
            //Assert
           // var value = result as ObjectResult;
            Assert.Equal(result, exptData);
        }

        [Fact]
        public void Test_GetByID_ReturnRecord_ByID()
        {
            //Arrange
            var mockRepo=new Mock<IDataRepository<Employee>>();
            var exptData = ExpectEmpData();
            mockRepo.Setup(x => x.Get(1)).Returns(exptData[0]);
            var controller=new EmployeeController(mockRepo.Object);
            //Act
            var result = controller.Get(1);
            //Assert
            Assert.NotNull(result);
            //var success = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(exptData[0].EmployeeID, result.);
            Assert.True(exptData[0].EmployeeID.ToString() == result.ToString());
            //Assert.Equal(result, success);
            //Assert.NotNull(productResult);
            //Assert.Equal(productList[1].ProductId, productResult.ProductId);
            //Assert.True(productList[1].ProductId == productResult.ProductId);
        }
        [Fact]
        public void Test_GetByID_ReturnNull()
        {
            //Arrange
            var mockRepo=new Mock<IDataRepository<Employee>>();
            var controller=new EmployeeController(mockRepo.Object);
            //Act
            var result = controller.Get(0);
            //Assert
            var badrequest=Assert.IsType<BadRequestObjectResult>(result);
            //Assert.Equal("")
        }

        public List<Employee> ExpectEmpData()
        {
            var exptData = new List<Employee>();
            exptData.Add(new Employee()
            {
                EmployeeID = 1,
                EmployeeName = "Vinay",
                DateOfBirth = new DateTime(2022 - 12 - 27),
                PhoneNumber = 9553358351,
                Email = "vinay@gmail.com"
            });
            exptData.Add(new Employee()
            {
                EmployeeID = 2,
                EmployeeName = "Vinay",
                DateOfBirth = new DateTime(2022 - 12 - 27),
                PhoneNumber = 9553358351,
                Email = "vinay@gmail.com"
            });
            exptData.Add(new Employee()
            {
                EmployeeID = 3,
                EmployeeName = "Vinay",
                DateOfBirth = new DateTime(2022 - 12 - 27),
                PhoneNumber = 9553358351,
                Email = "vinay@gmail.com"
            });
            return exptData;
        }
    }
}