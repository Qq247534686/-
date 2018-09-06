using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using JiaMiXiu.Model.IEntity;

namespace JiaMiXiu.Model.Entity
{	
   [Table("Member")]
   public partial class MemberEntity:BaseEntity
    {
		/// <summary>
        /// 
        /// </summary>		
		public Guid Id { get; set; }
		/// <summary>
        /// 名称
        /// </summary>		
		public string Name { get; set; }
		/// <summary>
        /// 性别：1男2女3保密
        /// </summary>		
		public int? Sex { get; set; }
		/// <summary>
        /// 生日
        /// </summary>		
		public DateTime? Birthday { get; set; }
		/// <summary>
        /// 所在地
        /// </summary>		
		public string Place { get; set; }
		/// <summary>
        /// 常出没地
        /// </summary>		
		public string CommonPlace { get; set; }
		/// <summary>
        /// 签名
        /// </summary>		
		public string Sign { get; set; }
		/// <summary>
        /// true:认证，false:未认证
        /// </summary>		
		public bool? Authentication { get; set; }
		/// <summary>
        /// 密码
        /// </summary>		
		public string Password { get; set; }
		/// <summary>
        /// 电话
        /// </summary>		
		public string Phone { get; set; }
		/// <summary>
        /// 当前经验
        /// </summary>		
		public int? Experience { get; set; }
		/// <summary>
        /// 等级
        /// </summary>		
		public Guid? GradeId { get; set; }
		/// <summary>
        /// 加米币
        /// </summary>		
		public decimal? JiaMiCoin { get; set; }
		/// <summary>
        /// 加米币
        /// </summary>		
		public decimal? Money { get; set; }
		/// <summary>
        /// 头像
        /// </summary>		
		public byte[] HeadPortrait { get; set; }
		/// <summary>
        /// 注册时间
        /// </summary>		
		public DateTime? RegisterTime { get; set; }
		 
    }

}
