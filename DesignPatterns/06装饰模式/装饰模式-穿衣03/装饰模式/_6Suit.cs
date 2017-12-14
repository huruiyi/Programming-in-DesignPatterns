using System;

namespace 装饰模式
{
    internal class _6Suit : Finery
    {
        public override void Show()
        {
            Console.Write("西装 ");
            base.Show();
        }
    }
}