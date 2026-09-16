namespace ProductsManagement.Dtos;

public class ProductRequest
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required decimal Price { get; set; }
}