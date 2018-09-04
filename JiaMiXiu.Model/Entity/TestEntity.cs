using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using JiaMiXiu.Model.IEntity;

namespace JiaMiXiu.Model.Entity
{	
   [Table("Test")]
   public partial class TestEntity:BaseEntity
    {
		/// <summary>
        /// 
        /// </summary>		
		public Guid Id { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public string Test { get; set; }
		 
    }

}
