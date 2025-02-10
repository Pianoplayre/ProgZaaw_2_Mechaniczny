using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HamburgerMenuDemo
{
    
        class UserContext : DbContext
        {
            public UserContext()
            : base( "DbConnection")
            { }

            public DbSet<Users> UsersHere { get; set; }
            public DbSet<Requirements> RequirementsHere { get; set; }
            public DbSet<Cars> CarsHere { get; set; }
            public DbSet<Roles> RolesHere { get; set; }
            public DbSet<CarTechInfo> CarTechInfoHere { get; set; }
            

        
            public DbSet<Orders> Orders_Here { get; set; }

            public DbSet<Contracts> ContractsHere { get; set; }



        }

    
}
