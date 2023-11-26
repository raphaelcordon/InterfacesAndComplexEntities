using Project.Enum.Product;

namespace Project.Entity.Product;

public abstract class Product : Base
{
    public Product(string name, ProductPrice price, ProductType productType)
    {
        Name = name;
        Price = price;
        ProductType = productType;
    }
    
    public string Name { get; }
    public ProductPrice Price { get; }
    public ProductType ProductType { get; }
}