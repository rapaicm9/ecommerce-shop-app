using Ordering.Domain.Models;
using Ordering.Domain.ValueObjects;

namespace Ordering.Infrastructure.Data.Extensions
{
    internal class InitialData
    {
        public static IEnumerable<Customer> Customers =>
        new List<Customer>
        {
            Customer.Create(CustomerId.Of(new Guid("58c49479-ec65-4de2-86e7-033c546291aa")), "Mihajlo","mihajlo@gmail.com"),
            Customer.Create(CustomerId.Of(new Guid("189dc8dc-990f-48e0-a37b-e6f2b60b9d7d")), "Pavle","pavle@gmail.com")
        };

        public static IEnumerable<Product> Products =>
        new List<Product>
        {
            Product.Create(ProductId.Of(new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61")), "IPhone X", 500),
            Product.Create(ProductId.Of(new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914")), "Samsung 10", 400)
        };

        public static IEnumerable<Order> Orders
        {
            get
            {
                var address1 = Address.Of("Mihajlo", "Rapax", "mihajlo@gmail.com", "adresa", "Serbia", "Novi Sad", "21000");

                var payment1 = Payment.Of("Mihajlo", "55555555555554444", "12/26", "888", 1);

                var order1 = Order.Create(
                    OrderId.Of(Guid.NewGuid()),
                    CustomerId.Of(new Guid("58c49479-ec65-4de2-86e7-033c546291aa")),
                    OrderName.Of("orde1"),
                    shippingAddress: address1,
                    billingAddress: address1,
                    payment1
                    );
                order1.Add(ProductId.Of(new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61")), 2, 500);
                order1.Add(ProductId.Of(new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914")), 1, 400);

                return new List<Order> { order1 };
            }
        }
    }
}
