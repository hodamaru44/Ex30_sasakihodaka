using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Insect:Animal
    {
        public Insect(DateTime bd, string n, float w = 0, float h = 0, float d = 0) : base(bd, n, w, h, d)
        {

        }
        new public void SelfIntroduction()
        {
            Console.WriteLine($"この昆虫は{name}です。");
        }
    }
}
