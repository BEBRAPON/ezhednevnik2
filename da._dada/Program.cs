using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da._dada
{
    internal class Program
    {
        static void Main()
        {
            Strelki();
        }
        public static int pos = 2;
        static DateTime date = DateTime.Now;
        public static string date1 = date.ToShortDateString();
        static ConsoleKeyInfo key = new ConsoleKeyInfo();
        static void Strelki ()
        {
            while (key.Key != ConsoleKey.Enter || key.Key != ConsoleKey.Escape)
            {
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos < 2)
                    {
                        pos++;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                }
                Console.Clear();
                Console.WriteLine("Выбранная дата: " + date1);
                Console.WriteLine("=========================");
                Zametki();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                {
                    Perecldat();
                }
            }   
            
        }
        static void Perecldat()
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                date = date.AddDays(-1);
                date1 = date.ToShortDateString();
                Main();
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                date = date.AddDays(1);
                date1 = date.ToShortDateString();
                Main();
            }
        }
        static void Zametki()
        {
            if (date1 == "08.11.2022")
                Zametka1();
            if (date1 == "10.11.2022")
                Zametka2();
            if (date1 == "15.11.2022")
                Zametka3();
            if (date1 == "20.11.2022")
                Zametka4();
            if (date1 == "25.11.2022")
                Zametka5();
        }
        static void PodzametkaForZametka1()
        {
            if (key.Key == ConsoleKey.Enter)
            {
                if (pos == 2)
                    Podzametka1_1();
                if (pos == 3)
                    Podzametka2_1();
            }
            
        }
        static void PodzametkaForZametka2()
        {
            if (key.Key == ConsoleKey.Enter)
            {
                if (pos == 2)
                    Podzametka1_2();
                if (pos == 3)
                    Podzametka2_2();
            }

        }
        static void PodzametkaForZametka3()
        {
            if (key.Key == ConsoleKey.Enter)
            {
                if (pos == 2)
                    Podzametka1_3();
                if (pos == 3)
                    Podzametka2_3();
            }

        }
        static void PodzametkaForZametka4()
        {
            if (key.Key == ConsoleKey.Enter)
            {
                if (pos == 2)
                    Podzametka1_4();
                if (pos == 3)
                    Podzametka2_4();
            }

        }
        static void PodzametkaForZametka5()
        {
            if (key.Key == ConsoleKey.Enter)
            {
                if (pos == 2)
                    Podzametka1_5();
                if (pos == 3)
                    Podzametka2_5();
            }

        }
        static void Zametka1()
        {
            List<string> zam1 = new List<string> {"1)Поиграть в компуктер.\r\n  2)Поспать." };
            foreach (string i in zam1)
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("  " + i);
            }
            PodzametkaForZametka1();
        }
        static void Podzametka1_1()
        {
            Console.Clear();
            List<string> podzam1 = new List<string> {"Текущая заметка: Поиграть в компуктер.\r\n=========================\r\nОписание: поиграть в компуктер и компуктер\r\n" +
                "Время: 02:02" };
            while (key.Key != ConsoleKey.Backspace)
            {
                foreach (string i in podzam1)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Console.WriteLine("Чтобы вернуться к выборам дат нажмите \"Backspace\".");
                }
                key = Console.ReadKey();
            }
            Console.Clear();
            Main();
        }
        static void Podzametka2_1()
        {
            Console.Clear();
            List<string> podzam2 = new List<string> { "Текущая заметка: Поспать.\r\n=========================\r\nОписание: просто поспать.\r\nВремя: 10:10" };
            while (key.Key != ConsoleKey.Backspace)
            {
                foreach (string i in podzam2)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Console.WriteLine("Чтобы вернуться к выборам дат нажмите \"Backspace\".");
                }
                key = Console.ReadKey();
            }
            Console.Clear();
            Main();
        }
        static void Zametka2()
        {
            List<string> zam2 = new List<string> { "1)Переделать ижидневник жи есть.\r\n  2)Покушать." };
            foreach (string i in zam2)
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("  " + i);
            }
            PodzametkaForZametka2();
            
        }
        static void Podzametka1_2()
        {
            Console.Clear();
            List<string> podzam1 = new List<string> { "Текущая замтека: Переделелать ижидневник жи есть.\n=========================\nОписание: переписать код.\nВремя: 15:15." };
            while (key.Key != ConsoleKey.Backspace)
            {
                foreach (string i in podzam1)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Console.WriteLine("Чтобы вернуться к выборам дат нажмите \"Backspace\".");
                }
                key = Console.ReadKey();
            }
            Console.Clear();
            Main();
        }
        static void Podzametka2_2()
        {
            Console.Clear();
            List<string> podzam2 = new List<string> { "Текущая заметка: Покушать.\n=========================\nОписание: вкусно похавать.\nВремя:  17:00." };
            while (key.Key != ConsoleKey.Backspace)
            {
                foreach (string i in podzam2)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Console.WriteLine("Чтобы вернуться к выборам дат нажмите \"Backspace\".");
                }
                key = Console.ReadKey();
            }
            Console.Clear();
            Main();
        }
        static void Zametka3()
        {
            List<string> zam3 = new List<string> { "1)Подготовиться к ИГЭ па банкаю.\r\n  2)Сдать ИГЭ па банкай." };
            foreach (string i in zam3)
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("  " + i);
            }
            PodzametkaForZametka3();
        }
        static void Podzametka1_3()
        {
            Console.Clear();
            List<string> podzam1 = new List<string> { "Текущая замтека: Подготовиться к ИГЭ па банкай.\n=========================\nОписание: подготовиться к подготовке.\nВремя: 10:15." };
            while (key.Key != ConsoleKey.Backspace)
            {
                foreach (string i in podzam1)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Console.WriteLine("Чтобы вернуться к выборам дат нажмите \"Backspace\".");
                }
                key = Console.ReadKey();
            }
            Console.Clear();
            Main();
        }
        static void Podzametka2_3()
        {
            Console.Clear();
            List<string> podzam2 = new List<string> { "Текущая замтека: Сдать ИГЭ па банкай.\n=========================\nОписание: после подготовки к водготовке сдать ИГЭ.\nВремя: 15:15." };
            while (key.Key != ConsoleKey.Backspace)
            {
                foreach (string i in podzam2)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Console.WriteLine("Чтобы вернуться к выборам дат нажмите \"Backspace\".");
                }
                key = Console.ReadKey();
            }
            Console.Clear();
            Main();
        }
        static void Zametka4()
        {
            List<string> zam4 = new List<string> { "1)Пойти в больницу.\r\n  2)Сдать все практические." };
            foreach (string i in zam4)
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("  " + i);
            }
            PodzametkaForZametka4();
        }
        static void Podzametka1_4()
        {
            Console.Clear();
            List<string> podzam1 = new List<string> { "Текущая замтека: Пойти в больницу.\n=========================\nОписание: пойти в больницу.\nВремя: 15:19." };
            while (key.Key != ConsoleKey.Backspace)
            {
                foreach (string i in podzam1)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Console.WriteLine("Чтобы вернуться к выборам дат нажмите \"Backspace\".");
                }
                key = Console.ReadKey();
            }
            Console.Clear();
            Main();
        }
        static void Podzametka2_4()
        {
            Console.Clear();
            List<string> podzam2 = new List<string> { "Текущая замтека: Сдать все практические.\n=========================\nОписание: сдать все долги.\nВремя: 20:15." };
            while (key.Key != ConsoleKey.Backspace)
            {
                foreach (string i in podzam2)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Console.WriteLine("Чтобы вернуться к выборам дат нажмите \"Backspace\".");
                }
                key = Console.ReadKey();
            }
            Console.Clear();
            Main();
        }
        static void Zametka5()
        {
            List<string> zam4 = new List<string> { "1)Посмотреть онемэ.\r\n  2)Посидеть в телефоне." };
            foreach (string i in zam4)
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("  " + i);
            }
            PodzametkaForZametka5();
        }
        static void Podzametka1_5()
        {
            Console.Clear();
            List<string> podzam1 = new List<string> { "Текущая замтека: Посмотреть онемэ.\n=========================\nОписание: посмотреть какое-нибудь коротенькое аниме.\n" +
                "Время: 14:20." };
            while (key.Key != ConsoleKey.Backspace)
            {
                foreach (string i in podzam1)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Console.WriteLine("Чтобы вернуться к выборам дат нажмите \"Backspace\".");
                }
                key = Console.ReadKey();
            }
            Console.Clear();
            Main();
        }
        static void Podzametka2_5()
        {
            Console.Clear();
            List<string> podzam2 = new List<string> { "Текущая замтека: Посидеть в телефоне.\n=========================\nОписание: посидеть в тиктоке.\nВремя: 20:50." };
            while (key.Key != ConsoleKey.Backspace)
            {
                foreach (string i in podzam2)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Console.WriteLine("Чтобы вернуться к выборам дат нажмите \"Backspace\".");
                }
                key = Console.ReadKey();
            }
            Console.Clear();
            Main();
        }
    }
}
