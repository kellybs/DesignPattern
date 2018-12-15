using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 充当外观角
    /// </summary>
    class BackUpFacade
    {
        //维持对其他对象的引用
        private readonly MailList mail;
        private readonly Sms sms;
        private readonly Photo photo;
        private readonly Song song;

        public BackUpFacade()
        {
            mail = new MailList();
            sms = new Sms();
            photo = new Photo();
            song = new Song();
        }

        /// <summary>
        /// 备份：调用其他对象的业务方法
        /// </summary>
        public void OneKeyBackup()
        {
            mail.BackUpMail();
            sms.BackUpSms();
            photo.BackUpPhoto();
            song.BackUpSong();
        }


    }
}
