using Project.Entity.Product;
using Project.Enum.Product;
using Project.Interfaces.Product;

namespace Project.Controller.Product;

public class FoodController : IFood
{
    public Food CreateFood(string name, ProductPrice price, FoodType foodType, ProductType productType)
    {
        var food = new Food(name, price, foodType, productType);

        return food;
    }

    public void WriteOnScreen(Food data)
    {
        Console.WriteLine("Creating Food");
        Console.WriteLine($"Id: {data.Id}, " +
                          $"Name: {data.Name}, " +
                          $"Price: {data.Price.Price}, " +
                          $"Type: {data.FoodType}");
        Console.WriteLine("=================");
    }
}