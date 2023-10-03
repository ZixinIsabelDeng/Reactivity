
using System.Data.Common;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        //this is a constructor
        public DataContext (DbContextOptions options) : base(options)
        {
            //we need a connection string

        }

       public DbSet<Activity> Activities { get; set;}

    }
        
    
}