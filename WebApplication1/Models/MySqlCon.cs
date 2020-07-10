using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MySqlCon : DbContext
    {
        //MySql Database connection String
        public MySqlCon() : base(nameOrConnectionString: "DefaultConnection")
        {
            this.Configuration.ValidateOnSaveEnabled = false;
        }
        public DbSet<Farmacies> Farmacies { get; set; }
        public DbSet<Sucursal> Sucursals { get; set; }
    }
}