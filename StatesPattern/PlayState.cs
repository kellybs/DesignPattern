namespace StatesPattern
{
    /// <summary>
    /// 玩家抽象状态类
    /// </summary>
    public abstract class PlayState
    {
        /// <summary>
        /// 基本有效功能
        /// </summary>       
        public abstract void Play();

        /// <summary>
        /// 熟练级 增加游戏胜利积分加倍功能
        /// </summary>
        /// <param name="result"></param>
        public abstract void DoubleScore(int result);

       
        /// <summary>
        /// 高手机 换牌功能
        /// </summary>
        public abstract void ChangeCards();

        /// <summary>
        /// 骨灰级偷看别人牌
        /// </summary>
        public abstract void PeekCards();
             
    }
}
