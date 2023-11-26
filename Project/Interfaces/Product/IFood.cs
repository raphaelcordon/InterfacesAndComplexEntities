using Project.Entity.Product;
using Project.Enum.Product;

namespace Project.Interfaces.Product;

public interface IFood : IBase<Food>
{
    Food CreateFood(string name, ProductPrice price, FoodType foodType, ProductType productType);
}