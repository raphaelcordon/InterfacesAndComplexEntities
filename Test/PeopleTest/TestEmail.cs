using Project.Entity.People;
using Xunit;

namespace Test.PeopleTest;

public class TestEmail
{
    [Fact]
    public void TestCreateEmailFailingNull()
    {
        string nullEmail = null;

        var exception = Record.Exception(() => new EmailAddress(nullEmail));

        Assert.NotNull(exception);
        Assert.IsType<FormatException>(exception);
        Assert.Equal("Email cannot be null", exception.Message);
    }
    
    [Fact]
    public void TestCreateEmailFailingAtSign()
    {
        string nullEmail = "test.email.com";

        var exception = Record.Exception(() => new EmailAddress(nullEmail));

        Assert.NotNull(exception);
        Assert.IsType<FormatException>(exception);
        Assert.Equal("Format not compatible with email address", exception.Message);
    }
}