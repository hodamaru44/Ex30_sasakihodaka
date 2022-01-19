using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Refrigerator:Thing
    {
        public Refrigerator(string n, float w = 0, float h = 0, float d = 0, float p = 0) : base(n, w, h, d, p)
        {

        }
        public void SelfIntroduction()
        {
            Console.WriteLine($"{name}の冷蔵庫です。");
            Volume();
            Poids();
        }
    }
}
