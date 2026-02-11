using OnlineStore.Domain.Common;

namespace OnlineStore.Domain.Entities;

public class Product: BaseEntity
{
    public string Name { get;private set; }
    
    public string Sku { get;private set; }
    public decimal Price { get;private set; }
    public string Description { get;private set; }

    public Product(string name, string sku, decimal price, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required.", nameof(name));
        if (string.IsNullOrWhiteSpace(sku))
            throw new ArgumentException("SKU is required.", nameof(sku));
        if (price <= 0)
            throw new ArgumentException("Price must be greater than zero.", nameof(price));
        Name = name;
        Sku = sku;
        Price = price;
        Description = description;
    }
    public void UpdatePrice(decimal newPrice)
    {
        if (newPrice <= 0)
            throw new ArgumentException("Price must be greater than zero.", nameof(newPrice));
        Price = newPrice;
    }
}