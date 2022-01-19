using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Fish:Animal
    {
        public Fish(DateTime bd, string n, float w = 0, float h = 0, float d = 0) : base(bd, n, w, h, d)
        {
        }
        public void SelfIntroduction()
        {
            Console.Write($"この魚は{name}です。");
            Birthday();
            BirthdayConfirmation();
           
        }
    }
}
