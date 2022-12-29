﻿using System;

namespace _03._Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //По време на седмицата на Оскарите, градското кино пуска прожекции на някои от филмите, които са
            //номинирани в категорията за "Най-добър филм".В таблицата са показани кои са филмите и каква е цената
            //за прожекция спрямо залата, в която се прожектира филмът.
            //Филм                  normal          luxury          ultra luxury
            //A Star Is Born        7.50 лв.        10.50 лв.       13.50 лв.
            //Bohemian Rhapsody     7.35 лв.        9.45 лв.        12.75 лв.
            //Green Book            8.15 лв.        10.25 лв.       13.25 лв.
            //The Favourite         8.75 лв.        11.55 лв.       13.95 лв.
            //Напишете програма, която изчислява какъв е приходът от даден филм, като знаете в какъв тип зала се
            //прожектира и колко човека са си купили билет за прожекцията.
            //Вход
            //Входът се чете от конзолата и се състои от три реда:
            // Първи ред – име на филм – текст("A Star Is Born", "Bohemian Rhapsody", "Green Book" или
            //"The Favourite")
            // Втори ред– вид на залата – текст("normal", "luxury" или "ultra luxury")
            // Трети ред – брой на закупените билети – цяло число в интервала[1...100]
            //Изход
            //На конзолата трябва да се отпечата един ред:
            //"{име на филма} -> {приходи от прожекцията на филма} lv."
            //Приходите да бъдат закръглени до втория знак след десетичната запетая.
            string movieTitle = Console.ReadLine();
            string typeOfProjecttion = Console.ReadLine();
            int numberOfViewers = int.Parse(Console.ReadLine());
            double priceOfTicket = 0;
            double income = 0;

            switch (movieTitle)
            {
                case "A Star Is Born":
                    switch (typeOfProjecttion)
                    {
                        case "normal":
                            priceOfTicket = 7.5;
                            income += priceOfTicket * numberOfViewers;
                            break;
                        case "luxury":
                            priceOfTicket = 10.5;
                            income += priceOfTicket * numberOfViewers;
                            break;
                        case "ultra luxury":
                            priceOfTicket = 13.5;
                            income += priceOfTicket * numberOfViewers;
                            break;
                    }
                    break;
                case "Bohemian Rhapsody":
                    switch (typeOfProjecttion)
                    {
                        case "normal":
                            priceOfTicket = 7.35;
                            income += priceOfTicket * numberOfViewers;
                            break;
                        case "luxury":
                            priceOfTicket = 9.45;
                            income += priceOfTicket * numberOfViewers;
                            break;
                        case "ultra luxury":
                            priceOfTicket = 12.75;
                            income += priceOfTicket * numberOfViewers;
                            break;
                    }
                    break;
                case "Green Book":
                    switch (typeOfProjecttion)
                    {
                        case "normal":
                            priceOfTicket = 8.15;
                            income += priceOfTicket * numberOfViewers;
                            break;
                        case "luxury":
                            priceOfTicket = 10.25;
                            income += priceOfTicket * numberOfViewers;
                            break;
                        case "ultra luxury":
                            priceOfTicket = 13.25;
                            income += priceOfTicket * numberOfViewers;
                            break;
                    }
                    break;
                case "The Favourite":
                    switch (typeOfProjecttion)
                    {
                        case "normal":
                            priceOfTicket = 8.75;
                            income += priceOfTicket * numberOfViewers;
                            break;
                        case "luxury":
                            priceOfTicket = 11.55;
                            income += priceOfTicket * numberOfViewers;
                            break;
                        case "ultra luxury":
                            priceOfTicket = 13.95;
                            income += priceOfTicket * numberOfViewers;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"{movieTitle} -> {income:f2} lv.");
        }
    }
}
