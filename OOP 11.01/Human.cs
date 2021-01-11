using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11._01
{
    class Human
    {
        public string Name { get; set; }
        public int Old { get; set; }
        public string Sex { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Привет, я {Name}");
        }

        public void SayByeAndGender()
        {
            Console.WriteLine($"До свидания! И кстати, я идентифицирую себя как {Sex}");
        }

    }
}
