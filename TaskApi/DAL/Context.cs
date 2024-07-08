using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TaskApi.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

       public DbSet<Models.Tasks> Tasks { get; set; }
    }
}
