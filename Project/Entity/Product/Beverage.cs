using Project.Enum;
using Project.Enum.Product;

namespace Project.Entity.Product;

public class Beverage : Product
{
    public Beverage(string name, ProductPrice price, BeverageType beverageType, ProductType productType) : base(name, price, productType)
    {
        BeverageType = beverageType;
    }
    
    public BeverageType BeverageType { get; }
}