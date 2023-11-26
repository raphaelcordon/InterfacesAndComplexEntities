using Project.Controller.People;
using Project.Controller.Product;
using Project.Controller.Sale;
using Project.Entity.Product;
using Project.Entity.Sale;
using Project.Enum.People;
using Project.Enum.Product;
using Project.Interfaces.People;
using Project.Interfaces.Product;
using Project.Interfaces.Sales;
using Xunit;

namespace Test.SaleTest;

public class TestSale
{
    IFood food = new FoodController();
    IBeverage beverage = new BeverageController();
    IClient client = new ClientController();
    IEmployee employee = new EmployeeController();
    ISale sale = new SaleController();

    [Fact]
    public void CreateSaleSuccessfully()
    {
        var food1Price = new ProductPrice(5.55f);
        var food1 = food.CreateFood("Hot Dog", food1Price, FoodType.Snack, ProductType.Food);
        
        var beverage1Price = new ProductPrice(2.35f);
        var beverage1 = beverage.CreateBeverage("Beer", beverage1Price, BeverageType.Alcoholic, ProductType.Beverage);
        
        var client1 = client.CreateClient("Joseph", "Test", "josh@email.com");
        var employee1 = employee.CreateEmployee("Mary", "Emp", EmployeeRole.Admin, "mary@email.com");
        
        var saleProducts1 = new SaleProductIds();
        saleProducts1.Add(food1.Id);
        saleProducts1.Add(beverage1.Id);
        var sale1 = sale.CreateSale(saleProducts1, client1, employee1);
        
        Assert.Contains(food1.Id, sale1.ProductIds);
        Assert.Contains(beverage1.Id, sale1.ProductIds);
        Assert.Equal(client1.Id, sale1.Client.Id);
        Assert.Equal(sale1.Id, sale1.Id);
    }
}