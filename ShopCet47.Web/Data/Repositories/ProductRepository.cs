using ShopCet47.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCet47.Web.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductsRepository
    {
        public ProductRepository(DataContext Context): base (Context)
        {

        }
    }
}
