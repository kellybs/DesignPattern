using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 抽象主题角色
    /// </summary>
    abstract class UserPermission
    {
        public abstract void PublistSubject();

        public abstract void ModifySubject(int id);

        public abstract void GetUserInfo(int userId);

        public abstract void ViewSubject(int id);
    }
}
