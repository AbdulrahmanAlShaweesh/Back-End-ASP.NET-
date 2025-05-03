

using Microsoft.AspNetCore.Identity;

namespace Route.Demo.DataAccess.Models.IdentityModel
{
    public class ApplicationUser  : IdentityUser 
    {
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
    }
}
