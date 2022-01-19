﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Worker:Person
    {
        public Worker(DateTime bd, string n, float w = 0, float h = 0, float d = 0) : base(bd, n, w, h, d)
        {

        }
        public void SelfIntroduction()
        {
            Console.WriteLine($"{name}の労働者です。");
            Birthday();
            BirthdayConfirmation();
           
        }
    }
}