using Ingressos.Models;
using Microsoft.EntityFrameworkCore;

namespace Ingressos.Data
{
    public class IngressosContext : DbContext
    {
        public IngressosContext(DbContextOptions<IngressosContext> options) : base(options)
        {
        }

        public DbSet<Ingresso> Ingressos { get; set; }
    }
}
