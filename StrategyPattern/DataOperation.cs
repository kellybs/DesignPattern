namespace StrategyPattern
{
    /// <summary>
    /// 充当环境类角色
    /// </summary>
    class DataOperation
    {
        private readonly ICipher cipher;//维持一个队抽象加密类的引用


        public DataOperation(ICipher cipher)
        {
            this.cipher = cipher;
        }


        public void ShowResult()
        {
            cipher.DoEncrypt("aabbcc");
        }
    }
}
