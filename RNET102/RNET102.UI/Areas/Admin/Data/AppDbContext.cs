using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace RNET102.UI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext (DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<RNET102.UI.Models.Blog> Blog { get; set; } = default!;
}
