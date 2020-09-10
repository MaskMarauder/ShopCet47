using ShopCet47.Web.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopCet47.Web.Data.Repositories
{
    public interface IRepository
    {
        void AddProduct(Product product);

        IEnumerable<Product> GetProduct();

        Product GetProduct(int id);

        bool ProductExists(int Id);

        void RemoveProduct(Product product);

        Task<bool> SaveAllAsync();

        void UpdateProduct(Product product);
    }
}