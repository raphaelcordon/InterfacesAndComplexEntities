using Project.Controller.People;
using Project.Entity.People;
using Project.Interfaces.People;
using Xunit;

namespace Test.PeopleTest;

public class TestClient
{
    IClient client = new ClientController();
    [Fact]
    public void TestCreateClientSuccessfully()
    {
        var client1 = client.CreateClient("testName", "testSurname", "email@email.com");
        
        Assert.Equal("testName", client1.Name);
        Assert.Equal("testSurname", client1.Surname);
        Assert.Equal("email@email.com", client1.Email.Email);
    }
}