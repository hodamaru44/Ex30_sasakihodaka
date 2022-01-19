using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Cat:Animal
    {
        
        public Cat(DateTime bd, string n, float w = 0, float h = 0, float d = 0) : base(bd, n, w, h, d)
        {
            
        }
       
         public void SelfIntroduction()
        {
            Console.WriteLine($"この猫の種類は{name}です。");
            Birthday();
            BirthdayConfirmation();
           
        }
    }
}
