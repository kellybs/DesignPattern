using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 通讯录类，充当子系统
    /// </summary>
    class MailList
    {
        public MailList()
        {
            Console.WriteLine("准备开始备份通讯录");
        }

        /// <summary>
        /// 备份通讯录
        /// </summary>
        public void BackUpMail()
        {
            Console.WriteLine("通讯录备份成功");
        }
    }
}
