using System;
using JiaMiXiu.Model.Entity;
using System.Data.Entity.ModelConfiguration;

namespace JiaMiXiu.Model.Mapping
{	
   public partial class TestEntityMap : EntityTypeConfiguration<TestEntity>
    {
	    public TestEntityMap()
        {
            this.HasKey(p => p.Id);
            this.ToTable("Test");
        }
    }

}
