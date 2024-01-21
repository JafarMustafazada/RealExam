using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationExam.Models;

namespace WebApplicationExam.Contexts;

public class Carvila01DbContext : IdentityDbContext<AppUser>
{
    public Carvila01DbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Comment> Comments { get; set; }
}
