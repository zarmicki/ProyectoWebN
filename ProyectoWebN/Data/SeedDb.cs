using ProyectoWebN.Data.Entity;

namespace ProyectoWebN.Data
{
    public class SeedDb
    {
        private readonly DataContext context;
        private Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedDbAsync()
        {

            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Products.Any())
            {
                this.AddProduct("Lavadora");
                this.AddProduct("Licuadora");
                this.AddProduct("Refrigerador");
                await this.context.SaveChangesAsync();
            }

            if (!this.context.cities.Any())
            {
                this.AddCity("La Paz");
                this.AddCity("Cochabamba");
                this.AddCity("Santa Cruz");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(100),
                IsActive = true,
                Stock = this.random.Next(100)
            }
                );
        }

        private void AddCity(string name)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                IsActive = true
            }
                );

        }
    }
}