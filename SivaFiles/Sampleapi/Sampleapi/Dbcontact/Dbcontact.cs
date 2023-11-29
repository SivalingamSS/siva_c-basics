using Microsoft.EntityFrameworkCore;
using Sampleapi.Modal;

namespace Sampleapi.Dbcontact
{
    public class Dbclass : DbContext
    {
        public Dbclass(DbContextOptions options) : base(options) { }
        
        public DbSet<modal> hospital { get;set; }
    }
}
