using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD1.Model;

namespace CRUD1.Data
{
    public class CRUD1Context : DbContext
    {
        public CRUD1Context (DbContextOptions<CRUD1Context> options)
            : base(options)
        {
        }

        public DbSet<CRUD1.Model.User> User { get; set; } = default!;
    }
}
