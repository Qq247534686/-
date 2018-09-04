using CorePlus.Algorithm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JiaMiXiu.Domain
{
    public class EF_DBContext : DbContext
    {

        public EF_DBContext() : base("Data Source=.;Initial Catalog=JiaMiXiu;Persist Security Info=True;User ID=sa;Password=" + Encryption.DecryptDES(ConfigurationManager.AppSettings["Pwd"]) + ";MultipleActiveResultSets=True;Application Name=EntityFramework")
        {
            this.Database.Initialize(false);
            this.Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.Load("JiaMiXIu.Model"));
            base.OnModelCreating(modelBuilder);
        }
    }
}
