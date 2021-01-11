using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11._01
{
    class Doctor : Human
    {
        public string Specialized { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Привет, я {Specialized} {Name}");
        }

        public void SayByeAndGender()
        {
            Console.WriteLine($"До свидания! И кстати, я идентифицирую себя как Врач-{Specialized}");
        }
    }
}
