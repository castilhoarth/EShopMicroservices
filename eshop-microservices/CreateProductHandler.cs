using System;
using System.Collections.Generic;
using System.Net;
namespace Catalog.API.Products.CreateProduct

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile,
	decimal Price) : ;

public record CreateProductResult(Guid Id);

internal class CreateProductCommandHandler
{
	
}
