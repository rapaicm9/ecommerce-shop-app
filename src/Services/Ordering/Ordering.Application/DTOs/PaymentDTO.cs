namespace Ordering.Application.DTOs;

public record PaymentDTO(
    string CardName,
    string CardNumber,
    string ExpirationDate,
    string Cvv,
    int PaymentMethod);
