using System;
using JiaMiXiu.Model.Entity;
using System.Data.Entity.ModelConfiguration;

namespace JiaMiXiu.Model.Mapping
{	
   public partial class GradeEntityMap : EntityTypeConfiguration<GradeEntity>
    {
	    public GradeEntityMap()
        {
            this.HasKey(p => p.Id);
            this.ToTable("Grade");
        }
    }

}
