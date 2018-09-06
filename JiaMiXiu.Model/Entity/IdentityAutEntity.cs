using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using JiaMiXiu.Model.IEntity;

namespace JiaMiXiu.Model.Entity
{	
   [Table("IdentityAut")]
   public partial class IdentityAutEntity:BaseEntity
    {
		/// <summary>
        /// 
        /// </summary>		
		public Guid Id { get; set; }
		/// <summary>
        /// 会员ID
        /// </summary>		
		public Guid MemberId { get; set; }
		/// <summary>
        /// 姓名
        /// </summary>		
		public string Name { get; set; }
		/// <summary>
        /// 身份证号码
        /// </summary>		
		public string Number { get; set; }
		/// <summary>
        /// 身份证正面照
        /// </summary>		
		public byte[] Positive { get; set; }
		/// <summary>
        /// 身份证反面照
        /// </summary>		
		public byte[] Opposite { get; set; }
		 
    }

}
