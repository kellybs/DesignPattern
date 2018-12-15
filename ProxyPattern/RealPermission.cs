using System;

namespace ProxyPattern
{
    /// <summary>
    /// 真实主题
    /// </summary>
    class RealPermission : UserPermission
    {
        /// <summary>
        /// 只有登录用户才能查看信息
        /// </summary>
        /// <param name="userId"></param>
        public override void GetUserInfo(int userId)
        {
            Console.WriteLine("用户获取自己详情");
        }

        /// <summary>
        /// 只有登录用户才能修改用户主题
        /// </summary>
        public override void ModifySubject(int userId)
        {
            Console.WriteLine("用户修改帖子");
        }


        /// <summary>
        /// 只有登录用户才能发表主题
        /// </summary>
        public override void PublistSubject()
        {
            Console.WriteLine("用户发表帖子");
        }

        /// <summary>
        /// 查看帖子
        /// </summary>
        /// <param name="id"></param>
        public override void ViewSubject(int id)
        {
            Console.WriteLine("用户浏览帖子");
        }
    }
}
