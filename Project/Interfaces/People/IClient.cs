using Project.Entity.People;

namespace Project.Interfaces.People;

public interface IClient : IBase<Client>
{
    Client CreateClient(string name, string surname, string email);
}