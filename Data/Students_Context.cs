using Microsoft.EntityFrameworkCore;
using StudentMngSys.Models;

namespace StudentMngSys.Data
{
    public class Students_Context: DbContext
    {
        public Students_Context(DbContextOptions<Students_Context>options): base(options) { }

        public DbSet<Students> Students { get; set; }
    }
}
