namespace BlazorServerExample.Models;

public class Product 
{
    public Product(){}

    public Product(long id, string name, string description, string image, decimal price, long categoryId)
    {
        Id = id;
        Name = name;
        Description = description;
        Image = image;
        Price = price;
        CategoryId = categoryId;
    }

    public long Id { get; }

    public string Name { get; } = string.Empty;

    public string Description { get; } = string.Empty;

    public string Image { get; } = string.Empty;

    public decimal Price { get; }

    public long CategoryId { get; }

    public Category Category { get; } = new();
}