using Project.Entity.People;
using Project.Entity.Sale;
using Project.Interfaces.Sales;

namespace Project.Controller.Sale;

public class SaleController : ISale
{
    public Entity.Sale.Sale CreateSale(SaleProductIds productIds, Client client, Employee employee)
    {
        var sale = new Entity.Sale.Sale(productIds, client, employee);

        return sale;
    }

    public void WriteOnScreen(Entity.Sale.Sale data)
    {
        Console.WriteLine("Creating Sale");
        Console.WriteLine($"Id: {data.Id}");
        foreach (var item in data.ProductIds)
        {
            Console.WriteLine($"Product: {item}");
        }
        Console.WriteLine("=================");
    }
}