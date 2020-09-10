using Microsoft.AspNetCore.Identity;

namespace ShopCet47.Web.Data.Entities
{
    public class User : IdentityUser
    {

        public string Firstname { get; set; }

        public string Lasttname { get; set; }

    }
}
