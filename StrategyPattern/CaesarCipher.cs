using System;

namespace StrategyPattern
{
    /// <summary>
    /// 凯撒加密类：充当具体策略角色
    /// </summary>
    class CaesarCipher : ICipher
    {
        public void DoEncrypt(string text)
        {
            Console.WriteLine($"文本：{text}凯撒加密成功");
        }
    }
}
