using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11._01
{
    class Troll : Human
    {
        string nickname = "Anonymous";

        public string GetNickname(string value)
        {
            if (value != null) value = nickname;
                return nickname;
            
        }

        public void SayHello()
        {
            Console.WriteLine($"Привет, я {Name}, но вы можете звать меня {nickname}");
        }

        public void SayByeAndGender()
        {
            Console.WriteLine($"До свидания! И кстати, я идентифицирую себя как Боевой вертолет");
        }

        public void ShowRealOld()
        {
            Console.WriteLine("Реальный возраст малолетнего тролля: 13 лет");
        }
    }
}
