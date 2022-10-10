using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Data;

public class ApplicationUser : IdentityUser<Guid>
{
    public int Age { get; set; }
    public string FullName { get; set; }
}