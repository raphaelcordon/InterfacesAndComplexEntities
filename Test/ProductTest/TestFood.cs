using Project.Controller.Product;
using Project.Entity.Product;
using Project.Enum.Product;
using Project.Interfaces.Product;
using Xunit;

namespace Test.ProductTest;

public class TestFood
{
    IFood food = new FoodController();

    [Fact]
    public void TestCreateFoodSuccessfully()
    {
        var testFoodPrice = new ProductPrice(5.50f);
        var testFood = food.CreateFood("Hot Dog", testFoodPrice, FoodType.Snack, ProductType.Food);
        
        Assert.Equal("Hot Dog", testFood.Name);
        Assert.Equal(5.50, testFood.Price.Price);
        Assert.Equal(FoodType.Snack, testFood.FoodType);
        Assert.Equal(ProductType.Food, testFood.ProductType);
    }
    
    [Fact]
    public void TestCreateFoodFailingPrice()
    {
        var testFoodPrice = -5.50f;
        
        var exception = Record.Exception(() => new ProductPrice(testFoodPrice));
        Assert.Equal("Price cannot be below zero.", exception.Message);

    }
}