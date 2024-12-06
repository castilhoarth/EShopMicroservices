using CatalogAPI.Models;
namespace CatalogAPI.API.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile,
    decimal Price) : ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);

internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, 
        CancellationToken cancellationToken) 
    {
        //Where we put the business logic
        var product = new Product
        {
            Name = command.Name,
            Category = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        return new CreateProductResult(Id: Guid.NewGuid());
    }
}
