using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 歌曲类，充当子系统
    /// </summary>
    class Song
    {
        public Song()
        {

            Console.WriteLine("准备开始备份歌曲");
        }

        /// <summary>
        /// 备份歌曲
        /// </summary>
        public void BackUpSong()
        {
            Console.WriteLine("歌曲备份成功");
        }
    }
}
