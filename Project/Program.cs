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

IFood food = new FoodController();
IBeverage beverage = new BeverageController();
IClient client = new ClientController();
IEmployee employee = new EmployeeController();
ISale sale = new SaleController();

// +----- P R O D U C T S -----+
Console.WriteLine("CREATING PRODUCTS");
var food1Price = new ProductPrice(5.55f);
var food2Price = new ProductPrice(60.50f);
var food1 = food.CreateFood("Hot Dog", food1Price, FoodType.Snack, ProductType.Food);
var food2 = food.CreateFood("Whey Protein", food2Price, FoodType.Fitness, ProductType.Food);
food.WriteOnScreen(food1);
food.WriteOnScreen(food2);

var beverage1Price = new ProductPrice(2.35f);
var beverage2Price = new ProductPrice(2f);
var beverage1 = beverage.CreateBeverage("Beer", beverage1Price, BeverageType.Alcoholic, ProductType.Beverage);
var beverage2 = beverage.CreateBeverage("Coca Cola", beverage2Price, BeverageType.Fizzy, ProductType.Beverage);
beverage.WriteOnScreen(beverage1);
beverage.WriteOnScreen(beverage2);

// +----- P E O P L E -----+
Console.WriteLine("CREATING PEOPLE");
var client1 = client.CreateClient("Joseph", "Test", "josh@email.com");
client.WriteOnScreen(client1);

var employee1 = employee.CreateEmployee("Mary", "Emp", EmployeeRole.Admin, "mary@email.com");
employee.WriteOnScreen(employee1);

// +----- S A L E S -----+
Console.WriteLine("CREATING SALES");
var saleProducts1 = new SaleProductIds();
saleProducts1.Add(food1.Id);
saleProducts1.Add(beverage2.Id);
var sale1 = sale.CreateSale(saleProducts1, client1, employee1);
sale.WriteOnScreen(sale1);