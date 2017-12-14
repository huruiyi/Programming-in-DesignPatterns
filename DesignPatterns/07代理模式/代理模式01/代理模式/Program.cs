﻿using System;

namespace 代理模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "李娇娇";

            Pursuit zhuojiayi = new Pursuit(jiaojiao);

            zhuojiayi.GiveDolls();
            zhuojiayi.GiveFlowers();
            zhuojiayi.GiveChocolate();

            Console.Read();
        }
    }

    //追求者
    internal class Pursuit
    {
        private SchoolGirl mm;

        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + " 送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + " 送你鲜花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + " 送你巧克力");
        }
    }

    //被追求者
    internal class SchoolGirl
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}