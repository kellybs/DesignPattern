using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 抽象策略角色
    /// </summary>
    interface ICipher
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="text">加密的文本</param>
        void DoEncrypt(string text);
    }
}
