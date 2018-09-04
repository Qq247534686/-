using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiaMiXiu.Model.IEntity
{
    public interface IUpdateInfo
    {
        Guid? UpdateUserId { get; set; }
        DateTime? UpdateTime { get; set; }
    }
}
