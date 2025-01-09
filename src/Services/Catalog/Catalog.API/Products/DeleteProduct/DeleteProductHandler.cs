﻿using Catalog.API.Products.CreateProduct;

namespace Catalog.API.Products.DeleteProduct;

public record DeleteProductCommand(Guid Id) : ICommand<DeleteProductResult>;
public record DeleteProductResult(bool IsSuccess);

public class DeleteCommandValidator : AbstractValidator<DeleteProductCommand>
{
    public DeleteCommandValidator()
    {
        RuleFor(command => command.Id).NotEmpty().WithMessage("Product ID is required!");
    }
}
internal class DeleteProductCommandHandler
    (IDocumentSession session, ILogger<DeleteProductCommandHandler> logger)
    : ICommandHandler<DeleteProductCommand, DeleteProductResult>
{
    public async Task<DeleteProductResult> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
    {
        logger.LogInformation("DeleteProductCommandHandler.Handle called with {@Command}", command);

        session.Delete<Product>(command.Id);
        await session.SaveChangesAsync(cancellationToken);

        return new DeleteProductResult(true);
    }
}

