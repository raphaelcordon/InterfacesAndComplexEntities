namespace Project.Entity;

public abstract class People
{
    public People(string name, string surname, EmailAddress email)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Email = email;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public EmailAddress Email { get; set; }
}