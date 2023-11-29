using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using crud_model.modal;
namespace crud_model.Dbcontact
{
    public class DbContact : DbContext

    { 
        public DbContact(DbContextOptions options) : base(options) { }

        public DbSet<model> Factory { get; set; }
        
    }
}
