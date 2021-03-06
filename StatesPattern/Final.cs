﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatesPattern
{
    /// <summary>
    /// 骨灰级
    /// </summary>
    public class Final : PlayState
    {
        private readonly string playName = "骨灰级";

        public override void ChangeCards()
        {
            Console.WriteLine($"{playName}玩家换牌了");
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
            Console.WriteLine($"{playName}玩家偷看别人牌");
        }

        public override void Play()
        {
            Console.WriteLine($"{playName}玩家正在玩游戏");
        }
    }
}
