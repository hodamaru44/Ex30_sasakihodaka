using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 物体
    /// </summary>
    class Thing
    {
        readonly public string name;
        public float width;
        public float height;
        public float depth;
        public float poids;
        public Thing(string n = null, float w = 0, float h = 0, float d = 0, float p = 0)
        {
            name = n;
            width = w;
            height = h;
            depth = d;
            poids = p;
        }
        public void Volume()
        {
            Console.WriteLine($"体積は{width * height * depth}です");
        }
        public void Poids()
        {
            Console.WriteLine($"体重は{poids}です。");
        }
    }
}
