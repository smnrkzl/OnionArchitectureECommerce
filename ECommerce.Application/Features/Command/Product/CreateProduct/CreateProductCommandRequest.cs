using MediatR;

namespace ECommerce.Application.Features.Command.Product.CreateProduct;

public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
{
    public string ProductName { get; set; }
    public int Stock { get; set; }
    public float Price { get; set; }
}
