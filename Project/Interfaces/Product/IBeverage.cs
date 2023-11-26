using Project.Entity.Product;
using Project.Enum.Product;

namespace Project.Interfaces.Product;

public interface IBeverage : IBase<Beverage>
{
    Beverage CreateBeverage(string name, ProductPrice price, BeverageType beverageType, ProductType productType);
}