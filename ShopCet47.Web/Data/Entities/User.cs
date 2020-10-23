
using Microsoft.AspNetCore.Identity;

namespace ShopCet47.Web.Data.Entities
{
    public class User : IdentityUser
    {

        public string FirstName { get; set; }


        public string LastName { get; set; }


    }
}