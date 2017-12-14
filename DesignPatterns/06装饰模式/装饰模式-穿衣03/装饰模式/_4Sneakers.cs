using System;

namespace 装饰模式
{
    internal class _4Sneakers : Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋 ");
            base.Show();
        }
    }
}