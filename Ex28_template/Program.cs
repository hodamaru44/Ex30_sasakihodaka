using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(DateTime.Now, "デジタル太郎", 0.5f, 160f, 50f);
            Console.WriteLine("Hello World!");
            Cat cat = new Cat(DateTime.Now, "ペルシャ", 4380, 10);
            cat.SelfIntroduction();
            Car car = new Car("マツダ", 4380, 10);
            car.SelfIntroduction();
            Fish fish = new Fish(DateTime.Now, "マグロ", 10);
            fish.SelfIntroduction();
            Insect insect= new Insect(DateTime.Now, "カブトムシ", 10);
            insect.SelfIntroduction();
            Student student = new Student(new DateTime(2001,1,20), "電子機械科", 10);
            insect.SelfIntroduction();
            Worker worker = new Worker(new DateTime(1997,7,2), "高校教師", 10);
        }
    }
}
