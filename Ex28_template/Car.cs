using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Car : Thing
    {
        public Car(string n , float w = 0, float h = 0, float d = 0, float p = 0) : base(n, w, h, d,p)
        {

        }
         public void SelfIntroduction()
        {
            Console.WriteLine($"{name}の自動車です。");
            Volume();
            Poids();
        }
    }
}
