using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerCrud.Models;

public class Product 
{
    public Product(){}

    public Product(long id, string name, decimal price, long categoryId)
    {
        Id = id;
        Name = name;
        Price = price;
        CategoryId = categoryId;
    }

    [Key]
    [Required(ErrorMessage = "Id is required")]
    public long Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [MaxLength(150, ErrorMessage = "Name cannot contain more than 150 characters")]
    [MinLength(4, ErrorMessage = "Name must have at least 3 characters")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Price is required")]
    [DataType(DataType.Currency)]
    [Range(1, 9999, ErrorMessage = "Price must be between 1 and 9999")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Category is required")]
    public long CategoryId { get; set; }

    public Category Category { get; } = new();
}