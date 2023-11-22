using Project.Entity;

namespace Project.Controller;

public class ClientController
{
    public ClientController()
    {
        
    }
    public Client CreateClient(string name, string surname, string email)
    {
        var createEmail = new EmailAddress(email);
        var client = new Client(name, surname, createEmail);

        return client;
    }
}