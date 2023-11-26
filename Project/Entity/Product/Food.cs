using Project.Enum;
using Project.Enum.Product;

namespace Project.Entity.Product;

public class Food : Product
{
    public Food(string name, ProductPrice price, FoodType foodType, ProductType productType) : base(name, price, productType)
    {
        FoodType = foodType;
    }
    
    public FoodType FoodType { get; }
}