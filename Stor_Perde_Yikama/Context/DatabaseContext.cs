using Stor_Perde_Yikama.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stor_Perde_Yikama.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Slayder> slayder { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new CreateDatabaseIfNotExists<DatabaseContext>());
        }
    }
}