﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiaMiXiu.Model.IEntity
{
    public interface ICreateInfo
    {
        Guid? CreateUserId { get; set; }
        DateTime? CreateTime { get; set; }
    }
}
