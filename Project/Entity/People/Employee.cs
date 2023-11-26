using Project.Enum;
using Project.Enum.People;
using Project.Enum.Product;

namespace Project.Entity.People;

public class Employee : People
{
    public Employee(string name, string surname, EmployeeRole role, EmailAddress emailAddress) : base (name, surname, emailAddress)
    {
        EmployeeRole = role;
    }
    
    public EmployeeRole EmployeeRole { get; }
}