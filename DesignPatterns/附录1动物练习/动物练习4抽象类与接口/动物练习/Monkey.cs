﻿namespace 动物练习
{
    internal class Monkey : Animal
    {
        public Monkey()
            : base()
        { }

        public Monkey(string name)
            : base(name)
        {
        }

        protected override string getShoutSound()
        {
            return "吱";
        }
    }
}