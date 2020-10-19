using System;

namespace StatesPattern
{
    /// <summary>
    /// 熟练级
    /// </summary>
    public class Secondary: PlayState
    {
        private readonly string playName = "熟练级";

        public override void ChangeCards()
        {
            Console.WriteLine($"{playName}玩家不能换牌");
        }

        public override void DoubleScore(int result)
        {
            if (result == 1)
            {
                Console.WriteLine($"{playName}玩家游戏胜利 积分加倍");
            }
            else
            {
                Console.WriteLine($"{playName}玩家游戏输了 积分扣除");
            }

        }

        public override void PeekCards()
        {
            Console.WriteLine($"{playName}玩家不能偷看别人牌");
        }

        public override void Play()
        {
            Console.WriteLine($"{playName}玩家正在玩游戏");
        }
    }
}
