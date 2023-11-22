using Project.Controller;
using Project.Enum;

var client = new ClientController();
var employee = new EmployeeController();

var client1 = client.CreateClient("Joseph", "Test", "josh@email.com");

Console.WriteLine("Creating Client");
Console.WriteLine($"Id: {client1.Id}, " +
                  $"Name: {client1.Name} {client1.Surname}, " +
                  $"Email: {client1.Email.Email}");
Console.WriteLine("=================");

Console.WriteLine("");

var employee1 = employee.CreateEmployee("Mary", "Emp", EmployeeRole.Admin, "mary@email.com");

Console.WriteLine("Creating Employee");
Console.WriteLine($"Id: {employee1.Id}, " +
                  $"Name: {employee1.Name} {employee1.Surname}, " +
                  $"Email: {employee1.Email.Email}, " +
                  $"Employee Role: {employee1.EmployeeRole}");
Console.WriteLine("=================");