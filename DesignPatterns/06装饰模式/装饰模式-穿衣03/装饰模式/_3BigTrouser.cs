using System;

namespace 装饰模式
{
    internal class _3BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮裤 ");
            base.Show();
        }
    }
}