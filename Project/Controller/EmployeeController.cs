using Project.Entity;
using Project.Enum;

namespace Project.Controller;

public class EmployeeController
{
    public Employee CreateEmployee(string name, string surname, EmployeeRole role, string email)
    {
        var createEmail = new EmailAddress(email);
        var employee = new Employee(name, surname, role, createEmail);

        return employee;
    }
}