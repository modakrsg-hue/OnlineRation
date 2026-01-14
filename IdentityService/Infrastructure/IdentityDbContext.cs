using Microsoft.EntityFrameworkCore;
using IdentityService.Domain;
using System.Collections.Generic;

namespace IdentityService.Infrastructure;

public class IdentityDbContext : DbContext
{
    public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
    : base(options) { }

    public DbSet<User> Users => Set<User>();
}
