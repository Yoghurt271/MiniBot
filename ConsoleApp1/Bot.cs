using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bot
    {
        public void ChatBot ()
        {
            Console.WriteLine("Привет");
            string text = Console.ReadLine();
            if (text.ToLower() == "привет")
            {
                Console.WriteLine("Как дела?");
            }

            text = Console.ReadLine();
            if (text.ToLower() == "отлично" || text.ToLower() == "нормально" || text.ToLower() == "плохо")
            {
                Console.WriteLine("Как вы себя чувствуете?");
            }

            text = Console.ReadLine();
            if (text.ToLower() == "отлично" || text.ToLower() == "нормально" || text.ToLower() == "плохо")
            {
                Console.WriteLine("Вас не беспокоят ночные кошмары?");
            }

            text = Console.ReadLine();
            if (text.ToLower() == "да" || text.ToLower() == "нет")
            {
                Console.WriteLine("Вас не посещает чувство что за вами кто то наблюдает?");
            }

            text = Console.ReadLine();
            if (text.ToLower() == "да")
            {
                Console.WriteLine("Тогда советую вам не смотреть в сторону той двери которая находиться прямо за вашей спиной");
            }
            else if (text.ToLower() == "нет")
            {
                Console.WriteLine("Посмотрите в дверной проём");
            }
            Console.ReadLine();


        }
    }
}
