using System;

namespace 装饰模式
{
    internal class _5TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤 ");
            base.Show();
        }
    }
}