using System;

namespace 装饰模式
{
    internal class _2Tie : Finery
    {
        public override void Show()
        {
            Console.Write("领带 ");
            base.Show();
        }
    }
}