using System;
using JiaMiXiu.Model.Entity;
using System.Data.Entity.ModelConfiguration;

namespace JiaMiXiu.Model.Mapping
{	
   public partial class LogonRecordEntityMap : EntityTypeConfiguration<LogonRecordEntity>
    {
	    public LogonRecordEntityMap()
        {
            this.HasKey(p => p.Id);
            this.ToTable("LogonRecord");
        }
    }

}
