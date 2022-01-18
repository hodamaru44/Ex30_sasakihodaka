using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person:Animal
    {
        public Person(DateTime bd, string n, float w = 0, float h = 0, float d = 0) : base(bd, n, w, h, d)
        {
        }
        public int Age(DateTime dateTime)          
        {
            int age = 0;
            DateTime today = DateTime.Now;
            age = today.Year - dateTime.Year;

            if (dateTime > today.AddYears(-age))
            {
                age -= 1;
            }
            return age;
        }
        public void Autoprésentation()
        {
            Console.WriteLine($"私は{name}です。");
        }
    }
}
