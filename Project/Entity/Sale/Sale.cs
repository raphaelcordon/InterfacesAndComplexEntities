using Project.Entity.People;

namespace Project.Entity.Sale;

public class Sale : Base
{
    public Sale(SaleProductIds productIds, Client client, Employee employee)
    {
        ProductIds = productIds;
        Client = client;
        Employee = employee;
    }
    public SaleProductIds ProductIds { get; }
    public Client Client { get; }
    public Employee Employee { get; set; }
}