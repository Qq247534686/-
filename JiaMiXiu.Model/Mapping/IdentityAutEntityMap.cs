using System;
using JiaMiXiu.Model.Entity;
using System.Data.Entity.ModelConfiguration;

namespace JiaMiXiu.Model.Mapping
{	
   public partial class IdentityAutEntityMap : EntityTypeConfiguration<IdentityAutEntity>
    {
	    public IdentityAutEntityMap()
        {
            this.HasKey(p => p.Id);
            this.ToTable("IdentityAut");
        }
    }

}
