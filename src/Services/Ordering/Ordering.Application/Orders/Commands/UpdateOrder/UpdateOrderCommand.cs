﻿using BuildingBlocks.CQRS;
using FluentValidation;
using Ordering.Application.DTOs;

namespace Ordering.Application.Orders.Commands.UpdateOrder
{
    public record UpdateOrderCommand(OrderDTO Order) : ICommand<UpdateOrderResult>;
    

    public record UpdateOrderResult(bool Success);

    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(x => x.Order.Id).NotEmpty().WithMessage("ID is required!");
            RuleFor(x => x.Order.OrderName).NotEmpty().WithMessage("Name is required!");
            RuleFor(x => x.Order.CustomerId).NotNull().WithMessage("CustomerId is required!");
        }
    }
}
