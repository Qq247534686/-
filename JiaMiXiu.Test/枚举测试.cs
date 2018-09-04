using System;
using JiaMiXu.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiaMiXiu.Test
{
    [TestClass]
    public class 枚举测试
    {
        [TestMethod]
        public void 枚举特性获取()
        {
            var vv = Sex.girl.GetAttributeValue();
            var cc =CustomEnumHelper.GetEnumKeyValue<Sex>();
            var ff = CustomEnumHelper.GetEnumAttKeyValue<Sex>();
        }
    }

    public enum Sex {
        [CustomEnum(value ="男孩")]
        boy=1,
        [CustomEnum(value = "女孩")]
        girl =9
    }
}
