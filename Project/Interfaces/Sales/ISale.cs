using Project.Entity.People;
using Project.Entity.Sale;

namespace Project.Interfaces.Sales;

public interface ISale : IBase<Sale>
{
    Sale CreateSale(SaleProductIds productIds, Client client, Employee employee);
}