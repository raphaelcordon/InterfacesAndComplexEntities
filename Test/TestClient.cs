using Project.Entity;
using Xunit;
using Xunit.Sdk;

namespace Test;

public class TestClient
{
    [Fact]
    public void TestCreateClientSuccessfully()
    {
        var email = new EmailAddress("email@email.com");
        var client = new Client("testName", "testSurname", email);
        
        Assert.Equal("testName", client.Name);
        Assert.Equal("testSurname", client.Surname);
        Assert.Equal("email@email.com", client.Email.Email);
    }
}