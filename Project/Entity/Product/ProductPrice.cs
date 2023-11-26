namespace Project.Entity.Product;

public class ProductPrice
{
    public ProductPrice(float price)
    {
        Price = price;
    }

    private float _price;

    public float Price
    {
        get => _price;
        private set
        {
            if (value < 0)
            {
                throw new FormatException("Price cannot be below zero.");
            }

            _price = value;
        }
    }
}