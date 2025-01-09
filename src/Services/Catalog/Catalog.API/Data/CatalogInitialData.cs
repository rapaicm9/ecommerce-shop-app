using Marten.Schema;

namespace Catalog.API.Data
{
    public class CatalogInitialData : IInitialData
    {
        public async Task Populate(IDocumentStore store, CancellationToken cancellation)
        {
            using var session = store.LightweightSession();

            if (await session.Query<Product>().AnyAsync())
                return;

            // Using UPSERT here
            session.Store<Product>(GetPreconfiguredProducts());
            await session.SaveChangesAsync();

        }

        private static IEnumerable<Product> GetPreconfiguredProducts() => new List<Product>()
        {
            new Product()
            {
                Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"),
                Name = "IPhone X",
                Description = "This phone is the company's biggest change to its flagship model",
                ImageFile = "product-1.jpg",
                Price = 950.00M,
                Category = new List<string> {"Smart Phone"}
            },
            new Product()
            {
                Id = new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"),
                Name = "Samsung Galaxy 10",
                Description = "This phone is the company's biggest change to its flagship model",
                ImageFile = "product-2.jpg",
                Price = 900.00M,
                Category = new List<string> {"Smart Phone"}
            },
            new Product()
            {
                Id = new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"),
                Name = "Xiaomi Ultra",
                Description = "This phone is the company's biggest change to its flagship model",
                ImageFile = "product-3.jpg",
                Price = 460.00M,
                Category = new List<string> {"Smart Phone"}
            },
            new Product()
            {
                Id = new Guid("b786103d-c621-4f5a-b498-23452610f88c"),
                Name = "Gorenje Dishwasher",
                Description = "Greatest Dishwasher ever",
                ImageFile = "product-4.jpg",
                Price = 200.00M,
                Category = new List<string> {"Dishwasher"}
            }
        };
    }
}
