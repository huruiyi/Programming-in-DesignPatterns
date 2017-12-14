using System;

namespace 装饰模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person xc = new Person("小菜");

            Console.WriteLine("\n第一种装扮：");
            _4Sneakers pqx = new _4Sneakers();
            pqx.Decorate(xc);

            _3BigTrouser kk = new _3BigTrouser();
            kk.Decorate(pqx);

            _5TShirts dtx = new _5TShirts();
            dtx.Decorate(kk);
            dtx.Show();

            Console.WriteLine("\n第二种装扮：");
            _1LeatherShoes px = new _1LeatherShoes();
            px.Decorate(xc);

            _2Tie ld = new _2Tie();
            ld.Decorate(px);

            _6Suit xz = new _6Suit();
            xz.Decorate(ld);
            xz.Show();

            Console.WriteLine("\n第三种装扮：");
            _4Sneakers pqx2 = new _4Sneakers();
            pqx2.Decorate(xc);

            _1LeatherShoes px2 = new _1LeatherShoes();
            px2.Decorate(pqx);

            _3BigTrouser kk2 = new _3BigTrouser();
            kk2.Decorate(px2);

            _2Tie ld2 = new _2Tie();
            ld2.Decorate(kk2);
            ld2.Show();

            Console.Read();
        }
    }
}