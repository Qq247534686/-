using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using JiaMiXiu.Model.IEntity;

namespace JiaMiXiu.Model.Entity
{	
   [Table("LogonRecord")]
   public partial class LogonRecordEntity:BaseEntity
    {
		/// <summary>
        /// 
        /// </summary>		
		public Guid Id { get; set; }
		/// <summary>
        /// 会员Id
        /// </summary>		
		public Guid MemberId { get; set; }
		/// <summary>
        /// 机器码
        /// </summary>		
		public string MachineCode { get; set; }
		/// <summary>
        /// 登录时间
        /// </summary>		
		public DateTime? LoginTime { get; set; }
		 
    }

}
