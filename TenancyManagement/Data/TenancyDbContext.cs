using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using TenancyShared.Entities;

namespace TenancyManagement.Data
{
    public class TenancyDbContext : IdentityDbContext<AspNetUser>
    {
        public TenancyDbContext(DbContextOptions<TenancyDbContext> options)
        : base(options) { }

    }
}
