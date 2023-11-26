using Project.Entity.Product;
using Project.Enum.Product;
using Project.Interfaces.Product;

namespace Project.Controller.Product;

public class BeverageController : IBeverage
{
    public Beverage CreateBeverage(string name, ProductPrice price, BeverageType beverageType, ProductType productType)
    {
        var beverage = new Beverage(name, price, beverageType, productType);

        return beverage;
    }

    public void WriteOnScreen(Beverage data)
    {
        Console.WriteLine("Creating Beverage");
        Console.WriteLine($"Id: {data.Id}, " +
                          $"Name: {data.Name}, " +
                          $"Price: {data.Price.Price}, " +
                          $"Type: {data.BeverageType}, " +
                          $"Product Type: {data.ProductType}");
        Console.WriteLine("=================");
    }
}