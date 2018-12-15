using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 代理主题角色
    /// </summary>
    class PermissionProxy
    {
        private readonly int userId;//0代表游客，否则是登录用户
        private readonly int subjectId;//帖子ID

        private readonly RealPermission rp = new RealPermission();
        public PermissionProxy(int uid,int sid)
        {
            userId = uid;
            subjectId = sid;
        }

        /// <summary>
        /// 用户是否有权限
        /// </summary>
        /// <returns></returns>
        bool Validate()
        {
            return userId > 0;
        }

        public void Detail()
        {
           
            // 浏览帖子，没有认知限制
            rp.ViewSubject(this.subjectId);

            if (Validate())
            {
                //登录用户可查看自己信息
                rp.GetUserInfo(this.userId);
            }
            else
            {
                Console.WriteLine("只有登录用户才能查看信息");
            }

            if (Validate())
            {
                //登录用户可发帖
                rp.PublistSubject();
            }
            else
            {
                Console.WriteLine("只有登录用户才能发表帖子");
            }

            if (Validate())
            {
                //登录用户可查看自己信息
                rp.ModifySubject(this.userId);
            }
            else
            {
                Console.WriteLine("只有登录用户才能修改帖子");
            }
        }

    }
}
