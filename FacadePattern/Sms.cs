using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 信息类，充当子系统
    /// </summary>
    class Sms
    {
        public Sms()
        {
            Console.WriteLine("准备开始备份短消息");
        }

        /// <summary>
        /// 备份信息
        /// </summary>
        public void BackUpSms()
        {
            Console.WriteLine("短消息备份成功");
        }
    }
}
