using Microsoft.EntityFrameworkCore;
using MvcAwsPostgres.Models;

namespace MvcAwsPostgres.Data
{
    public class DepartamentosContext : DbContext
    {
        public DepartamentosContext(DbContextOptions<DepartamentosContext>
            options) : base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
    }
}
