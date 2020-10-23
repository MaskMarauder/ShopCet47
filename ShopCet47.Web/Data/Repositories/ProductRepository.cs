using ShopCet47.Web.Data.Entities;

namespace ShopCet47.Web.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
