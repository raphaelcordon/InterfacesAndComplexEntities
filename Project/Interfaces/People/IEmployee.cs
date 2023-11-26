using Project.Entity.People;
using Project.Enum.People;

namespace Project.Interfaces.People;

public interface IEmployee : IBase<Employee>
{
    Employee CreateEmployee(string name, string surname, EmployeeRole role, string email);
}