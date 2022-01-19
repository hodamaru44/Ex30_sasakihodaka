using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Cicada:Insect
    {
        public string type;
        public Cicada(DateTime bd, string n, float w = 0, float h = 0, float d = 0,string f= "カメムシ目ヨコバイ亜目セミ科") : base(bd, n, w, h, d)
        {
            type = f;
        }
        public void SelfIntroduction()
        {
            Console.WriteLine($"このセミは{name}です。{type}の種類です");
            Birthday();
            BirthdayConfirmation();
            CicadaLifeSpan();
        }
    }
}
