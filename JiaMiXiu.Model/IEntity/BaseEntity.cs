using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace JiaMiXiu.Model.IEntity
{
    public class BaseEntity
    {
        public void SetCreateInfo()
        {
            var createInfo = this as ICreateInfo;
            var updateInfo = this as IUpdateInfo;
            createInfo.CreateTime = updateInfo.UpdateTime = DateTime.Now;
            createInfo.CreateUserId = null;//updateInfo.UpdateUserId = CookieHelper.GetUserInfo<UserInfoEntity>().Id;
        }

        public void SetUpdateInfo()
        {
            var updateInfo = this as IUpdateInfo;
            updateInfo.UpdateTime = DateTime.Now;
            updateInfo.UpdateUserId = null;//CookieHelper.GetUserInfo<UserInfoEntity>().Id;
        }
    }
}
