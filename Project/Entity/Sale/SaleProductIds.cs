namespace Project.Entity.Sale;

public class SaleProductIds : List<Guid>
{
    public SaleProductIds() : base()
    {
    }

    private IList<Guid> _productIds;

    private IList<Guid> ProductIds
    {
        get => _productIds;
        set => _productIds = value ?? throw new Exception("Sale must contain at least one product");
    }
}