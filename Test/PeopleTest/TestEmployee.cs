using Project.Entity.People;
using Project.Enum.People;
using Xunit;

namespace Test.PeopleTest;

public class TestEmployee
{
    [Fact]
    public void TestCreateEmployeeSuccessfully()
    {
        var email = new EmailAddress("email@email.com");
        var employee = new Employee("testName", "testSurname", EmployeeRole.Admin, email);
        
        Assert.Equal("testName", employee.Name);
        Assert.Equal("testSurname", employee.Surname);
        Assert.Equal(EmployeeRole.Admin, employee.EmployeeRole);
        Assert.Equal("email@email.com", employee.Email.Email);
    }
}