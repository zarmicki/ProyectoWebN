using ProyectoWebN.Data.Entity;

namespace ProyectoWebN.Data.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(DataContext context) : base(context)
        {

        }

    }
}