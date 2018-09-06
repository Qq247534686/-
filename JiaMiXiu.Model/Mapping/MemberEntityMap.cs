using System;
using JiaMiXiu.Model.Entity;
using System.Data.Entity.ModelConfiguration;

namespace JiaMiXiu.Model.Mapping
{	
   public partial class MemberEntityMap : EntityTypeConfiguration<MemberEntity>
    {
	    public MemberEntityMap()
        {
            this.HasKey(p => p.Id);
            this.ToTable("Member");
        }
    }

}
