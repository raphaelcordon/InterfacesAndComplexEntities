using Project.Entity.People;
using Project.Interfaces.People;

namespace Project.Controller.People;

public class ClientController: IClient
{
    public Client CreateClient(string name, string surname, string email)
    {
        var createEmail = new EmailAddress(email);
        var client = new Client(name, surname, createEmail);

        return client;
    }

    public void WriteOnScreen(Client data)
    {
        Console.WriteLine("Creating Client");
        Console.WriteLine($"Id: {data.Id}, " +
                  $"Name: {data.Name} {data.Surname}, " +
                  $"Email: {data.Email.Email}");
        Console.WriteLine("=================");
    }
    
}