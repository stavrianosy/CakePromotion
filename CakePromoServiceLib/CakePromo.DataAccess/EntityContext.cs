using CakePromo.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakePromo.DataAccess
{
    public class EntityContext:DbContext        
    {
        public EntityContext()
            : base("name=primaryConn")
        { }

        public DbSet<Cake> Cake { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<CakePhoto> CakePhoto { get; set; }
        public DbSet<Unit> Unit { get; set; }
    }
}
