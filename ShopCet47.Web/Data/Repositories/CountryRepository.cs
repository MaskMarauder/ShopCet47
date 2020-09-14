using ShopCet47.Web.Data.Entities;

namespace ShopCet47.Web.Data.Repositories
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context) : base(context)
        {

        }
    }
}
