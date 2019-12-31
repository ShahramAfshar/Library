using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.DatabaseContext
{
   public class MyDbContext : IdentityDbContext
    {
        public MyDbContext():base("DefaultConnection")
        {

        }


        //static MyDbContext()
        //{
        //    Database.SetInitializer(new
        //       MigrateDatabaseToLatestVersion<MyDbContext, Migrations.Configuration>());
        //}


    }
}
