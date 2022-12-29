﻿using System;

namespace _05._Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Атанас е алпинист, чиято следваща цел е изкачването на Еверест.Вашата задача е да напишете програма,
            //която да следи до каква височина е достигнал Атанас и за колко дни е изкачил върха. Той започва
            //изкачването си от ден първи от базов лагер, който е на 5 364 метра, а самият връх е на 8 848м.
            //Преди всяко изкачване на определени метри, Атанас може да си почине в някой лагер и да продължи на
            //следващия ден или да продължи изкачването без да спре, като максималното време, в което той може да
            //изкачва върха е 5 дни.Програмата приключва при получаване на командата "END", при достигане на върха
            //(8 848м) или при превишаване на разрешените 5 дни за изкачване.
            //Вход
            //От конзолата се четат по два реда до въвеждане на команда "END", ако са минали повече от 5 дни в
            //изкачване или се достигне върха(8 848м):
            //•	"Yes" / "No" - текст - дали Атанас ще нощува преди изкачването на следващите метри или не
            //•	Изкачени метри -цяло число в интервала[1...4000]
            //Изход
            //След получаване на командата "END", превишаване на разрешениете 5 дни за изкачване или се достигне върха
            //(8 848м), на конзолата се отпечатва:
            //•	Ако Атанас е изкачил Еверест:
            //"Goal reached for {брой дни които Атанас е изкачвал върха} days!"
            //•	Ако Атанас НЕ е изкачил Еверест:
            //"Failed!"
            //"{достигнатите от Атанас метри}"
            string action = string.Empty;
            int meters = 0;
            int days = 1;
            int height = 5364;
            bool isHeOntTheRightPath = action == "END" || days > 5 || height > 8848;
            while (!isHeOntTheRightPath)
            {
                action = Console.ReadLine();
                if (action == "END")
                {
                    break;
                }
                meters = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case "Yes":
                        days++;
                        if (days <= 5)
                        {

                            height += meters;
                        }
                        break;
                    case "No":
                        days = days;
                        height += meters;
                        break;
                }
                isHeOntTheRightPath = action == "END" || days > 5 || height > 8848;
            }
            if (action != "END" && height > 8848 && days <= 5)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{height}");
            }
        }
    }
}
