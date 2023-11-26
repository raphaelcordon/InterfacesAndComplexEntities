using Project.Entity.People;
using Project.Enum.People;
using Project.Interfaces.People;

namespace Project.Controller.People;

public class EmployeeController : IEmployee
{
    public Employee CreateEmployee(string name, string surname, EmployeeRole role, string email)
    {
        var createEmail = new EmailAddress(email);
        var employee = new Employee(name, surname, role, createEmail);
        
        return employee;
    }

    public void WriteOnScreen(Employee data)
    {
        Console.WriteLine("Creating Employee");
        Console.WriteLine($"Id: {data.Id}, " +
                  $"Name: {data.Name} {data.Surname}, " +
                  $"Email: {data.Email.Email}, " +
                  $"Employee Role: {data.EmployeeRole}");
        Console.WriteLine("=================");
    }
}