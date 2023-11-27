using Project.Controller.People;
using Project.Entity.People;
using Project.Enum.People;
using Project.Interfaces.People;
using Xunit;

namespace Test.PeopleTest;

public class TestEmployee
{
    IEmployee employee = new EmployeeController();
    [Fact]
    public void TestCreateEmployeeSuccessfully()
    {
        var employee1 = employee.CreateEmployee("testName", "testSurname", EmployeeRole.Admin, "email@email.com");
        
        Assert.Equal("testName", employee1.Name);
        Assert.Equal("testSurname", employee1.Surname);
        Assert.Equal(EmployeeRole.Admin, employee1.EmployeeRole);
        Assert.Equal("email@email.com", employee1.Email.Email);
    }
}