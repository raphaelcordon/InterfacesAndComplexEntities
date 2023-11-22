using Project.Enum;

namespace Project.Entity;

public class Employee : People
{
    public Employee(string name, string surname, EmployeeRole role, EmailAddress emailAddress) : base (name, surname, emailAddress)
    {
        EmployeeRole = role;
    }
    
    public EmployeeRole EmployeeRole { get; set; }
}