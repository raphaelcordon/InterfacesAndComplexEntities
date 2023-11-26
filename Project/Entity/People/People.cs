namespace Project.Entity.People;

public abstract class People : Base
{
    public People(string name, string surname, EmailAddress email)
    {
        Name = name;
        Surname = surname;
        Email = email;
    }
    public string Name { get; }
    public string Surname { get; }
    public EmailAddress Email { get; }
}