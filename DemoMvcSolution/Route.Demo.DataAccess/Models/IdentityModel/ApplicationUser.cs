

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Route.Demo.DataAccess.Models.IdentityModel
{
    public class ApplicationUser  : IdentityUser 
    {
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
    }
}
