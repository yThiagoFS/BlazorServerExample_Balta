using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerCrud.Models;

public class Category 
{
    public Category() {}
    
    public Category(long id, string name, string description) 
    {
        Id = id;
        Name = name;
        Description = description;
    }

    [Key]
    [Required(ErrorMessage = "Id is required.")]
    public long Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [MaxLength(50, ErrorMessage = "Name cannot contain more than 50 characters.")]
    [MinLength(3, ErrorMessage = "Name must have at least 3 characters.")]
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public List<Product> Products { get; set; } = new();
}