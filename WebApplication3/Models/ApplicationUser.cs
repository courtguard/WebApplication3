using Microsoft.AspNetCore.Identity;

namespace WebApplication3.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Pet> Pets  { get; set; }
    }
}
