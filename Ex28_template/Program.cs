using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(new DateTime(2018,8,4), "ペルシャ", 43, 10);
            cat.SelfIntroduction();
            Car car = new Car("マツダ", 7,10,9,1000);
            car.SelfIntroduction();
            Fish fish = new Fish(new DateTime(2010, 10, 5), "鮎", 1f, 5f); 
            fish.SelfIntroduction();
            Insect insect = new Insect(new DateTime(2020, 1, 10), "カブトムシ", 1f, 0f, 6f); 
            insect.SelfIntroduction();
            Student student = new Student(new DateTime(2001,1,20), "電子機械科");
            student.SelfIntroduction();
            Worker worker = new Worker(new DateTime(1997,7,2), "高校教師");
            worker.SelfIntroduction();
            Plant plant = new Plant(DateTime.Now, "カリフラワー", 7, 4, 2);
            plant.SelfIntroduction();
            Refrigerator refrigerator = new Refrigerator("ヒタチィ", 3, 3, 2, 50);
            refrigerator.SelfIntroduction();
        }
    }
}
