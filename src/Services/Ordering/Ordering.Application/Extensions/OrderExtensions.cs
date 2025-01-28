﻿using Ordering.Application.DTOs;
using Ordering.Domain.Models;

namespace Ordering.Application.Extensions;
public static class OrderExtensions
{
    public static IEnumerable<OrderDTO> ToOrderDtoList(this IEnumerable<Order> orders)
    {
        return orders.Select(order => new OrderDTO(
            Id: order.Id.Value,
            CustomerId: order.CustomerId.Value,
        OrderName: order.OrderName.Value,
            ShippingAddress: new AddressDTO(order.ShippingAddress.FirstName, order.ShippingAddress.LastName, order.ShippingAddress.EmailAddress!, order.ShippingAddress.AddressLine, order.ShippingAddress.Country, order.ShippingAddress.State, order.ShippingAddress.ZipCode),
            BillingAddress: new AddressDTO(order.BillingAddress.FirstName, order.BillingAddress.LastName, order.BillingAddress.EmailAddress!, order.BillingAddress.AddressLine, order.BillingAddress.Country, order.BillingAddress.State, order.BillingAddress.ZipCode),
            Payment: new PaymentDTO(order.Payment.CardName!, order.Payment.CardNumber, order.Payment.ExpirationDate, order.Payment.CVV, order.Payment.PaymentMethod),
        Status: order.Status,
            OrderItems: order.OrderItems.Select(oi => new OrderItemDTO(oi.OrderId.Value, oi.ProductId.Value, oi.Quantity, oi.Price)).ToList()
        ));
    }

    public static OrderDTO ToOrderDto(this Order order)
    {
        return DtoFromOrder(order);
    }

    private static OrderDTO DtoFromOrder(Order order)
    {
        return new OrderDTO(
                    Id: order.Id.Value,
                    CustomerId: order.CustomerId.Value,
        OrderName: order.OrderName.Value,
                    ShippingAddress: new AddressDTO(order.ShippingAddress.FirstName, order.ShippingAddress.LastName, order.ShippingAddress.EmailAddress!, order.ShippingAddress.AddressLine, order.ShippingAddress.Country, order.ShippingAddress.State, order.ShippingAddress.ZipCode),
                    BillingAddress: new AddressDTO(order.BillingAddress.FirstName, order.BillingAddress.LastName, order.BillingAddress.EmailAddress!, order.BillingAddress.AddressLine, order.BillingAddress.Country, order.BillingAddress.State, order.BillingAddress.ZipCode),
                    Payment: new PaymentDTO(order.Payment.CardName!, order.Payment.CardNumber, order.Payment.ExpirationDate, order.Payment.CVV, order.Payment.PaymentMethod),
        Status: order.Status,
                    OrderItems: order.OrderItems.Select(oi => new OrderItemDTO(oi.OrderId.Value, oi.ProductId.Value, oi.Quantity, oi.Price)).ToList()
                );
    }
}
