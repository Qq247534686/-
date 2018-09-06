using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using JiaMiXiu.Model.IEntity;

namespace JiaMiXiu.Model.Entity
{	
   [Table("Grade")]
   public partial class GradeEntity:BaseEntity
    {
		/// <summary>
        /// 
        /// </summary>		
		public Guid Id { get; set; }
		/// <summary>
        /// 等级名称
        /// </summary>		
		public string Name { get; set; }
		/// <summary>
        /// 经验值
        /// </summary>		
		public int Experience { get; set; }
		 
    }

}
