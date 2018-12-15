using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 照片类，充当子系统
    /// </summary>
    class Photo
    {
        public Photo()
        {
            Console.WriteLine("准备开始备份照片");
        }

        /// <summary>
        /// 备份信息
        /// </summary>
        public void BackUpPhoto()
        {
            Console.WriteLine("照片备份成功");
        }
    }
}
