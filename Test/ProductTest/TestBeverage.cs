using Project.Controller.Product;
using Project.Entity.Product;
using Project.Enum.Product;
using Project.Interfaces.Product;
using Xunit;

namespace Test.ProductTest;

public class TestBeverage
{
    IBeverage beverage = new BeverageController();

    [Fact]
    public void TestCreateBeverageSuccessfully()
    {
        var testBeveragePrice = new ProductPrice(2.50f);
        var testBeverage = beverage.CreateBeverage("Beer", testBeveragePrice, BeverageType.Alcoholic, ProductType.Beverage);
        
        Assert.Equal("Beer", testBeverage.Name);
        Assert.Equal(2.50, testBeverage.Price.Price);
        Assert.Equal(BeverageType.Alcoholic, testBeverage.BeverageType);
        Assert.Equal(ProductType.Beverage, testBeverage.ProductType);
    }
    
    [Fact]
    public void TestCreateBeverageFailingPrice()
    {
        var testBeveragePrice = -2.50f;
        
        var exception = Record.Exception(() => new ProductPrice(testBeveragePrice));
        Assert.Equal("Price cannot be below zero.", exception.Message);

    }
}