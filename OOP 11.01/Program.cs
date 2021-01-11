using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = "Макар";
            human.Old = 46;
            human.Sex = "Мужичара";

            human.SayHello();
            human.SayByeAndGender();

            Console.WriteLine();


            Doctor doc = new Doctor();
            doc.Name = "Ватсон";
            doc.Old = 61;
            doc.Sex = "Мужчина";
            doc.Specialized = "Отоларинголог";

            doc.SayHello();
            doc.SayByeAndGender();

            Console.WriteLine();

            Troll troll = new Troll();
            troll.Name = "Вениамин";
            troll.Old = 25;
            troll.Sex = "Мужик";

            troll.SayHello();
            troll.SayByeAndGender();
            troll.ShowRealOld();

            Console.ReadLine();
            
        }
    }
}
