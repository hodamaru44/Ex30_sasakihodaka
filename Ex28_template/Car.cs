using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Car : Thing
    {
        public Car(string n = null, float w = 0, float h = 0, float d = 0)
        {

        }
         public void SelfIntroduction()
        {
            Console.WriteLine($"{name}の自動車です。");
        }
    }
}
