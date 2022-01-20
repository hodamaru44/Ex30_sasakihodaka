using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(new DateTime(2018,8,4), "ペルシャ", 43, 10);//猫
            cat.SelfIntroduction();
            Car car = new Car("マツダ", 7,10,9,1000);//車
            car.SelfIntroduction();
            Fish fish = new Fish(new DateTime(2010, 10, 5), "鮎", 1f, 5f); //魚
            fish.SelfIntroduction();
            Insect insect = new Insect(new DateTime(2020, 1, 10), "カブトムシ", 1f, 0f, 6f); //昆虫
            insect.SelfIntroduction();
            Student student = new Student(new DateTime(2001,1,20), "電子機械科");//学生
            student.SelfIntroduction();
            Worker worker = new Worker(new DateTime(1997,7,2), "高校教師");//労働者
            worker.SelfIntroduction();
            Plant plant = new Plant(DateTime.Now, "カリフラワー", 7, 4, 2);//植物
            plant.SelfIntroduction();
            Refrigerator refrigerator = new Refrigerator("ヒタチィ", 3, 3, 2, 50);//冷蔵庫
            refrigerator.SelfIntroduction();
            Cicada cicada = new Cicada(new DateTime(2022, 1, 10), "クマゼミ", 4f, 0f, 6f);//セミ
            cicada.SelfIntroduction();
        }
    }
}
