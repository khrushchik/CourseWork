using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoursework.Models
{
    public class CourseworkDBContext: DbContext
    {
        public virtual DbSet<Joiner> Joiners { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Renter> Renters { get; set; }
        public CourseworkDBContext(DbContextOptions<CourseworkDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
