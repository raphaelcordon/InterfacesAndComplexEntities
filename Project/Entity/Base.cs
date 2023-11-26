namespace Project.Entity;

public class Base
{
    protected Base()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; }
}