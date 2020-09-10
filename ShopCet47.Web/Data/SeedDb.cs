using Microsoft.AspNetCore.Identity;
using ShopCet47.Web.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCet47.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly UserManager<User> _UserManager;
        private readonly Random _random;

        public SeedDb(DataContext context, UserManager<User> userManager)
        {
            _context = context;
            _UserManager = userManager;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await _UserManager.FindByEmailAsync("rafael.santos@cinel.pt");

            if (user == null)
            {
                user = new User
                {
                    Firstname = "Rafael",
                    Lasttname = "Santos",
                    Email = "rafael.santos@cinel.pt",
                    UserName = "rafael.santos@cinel.pt",
                };

                var result = await _UserManager.CreateAsync(user, "123456");
                if(result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }

            }

            if (!_context.Products.Any())
            {
                this.AddProduct("Iphone x", user);
                this.AddProduct("Rato Mickey", user);
                this.AddProduct("Iwatch series 4", user);
                this.AddProduct("Ipad 2", user);
                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name, User user)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(1000),
                IsAvailable = true,
                Stock = _random.Next(100),
                User = user

            }) ;
        }
    }
}
