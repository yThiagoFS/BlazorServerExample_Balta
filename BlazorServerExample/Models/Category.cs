namespace BlazorServerExample.Models;

public class Category 
{
    public Category() {}
    
    public Category(long id, string name, string description) 
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public long Id { get; }

    public string Name { get; } = string.Empty;

    public string Description { get; } = string.Empty;

    public List<Product> Products() { get; set; } = new();
}