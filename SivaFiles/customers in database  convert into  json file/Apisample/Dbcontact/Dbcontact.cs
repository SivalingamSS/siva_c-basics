using Apisample.Modal;
using Microsoft.EntityFrameworkCore;

namespace Apisample.Dbcontact
{
    public class  contactAPIDbcontext :DbContext
    {
      public contactAPIDbcontext (DbContextOptions options) : base (options) { }

        public DbSet <Employee> Customers
        {
            get;
            set;
        }
       
    }
}
