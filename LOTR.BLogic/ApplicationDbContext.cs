using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using LOTR;
using LOTR.Domain;

namespace LOTR.BLogic
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Comment> Comments { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
