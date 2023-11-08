using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Не_вирус.exe.bat
{
    internal class Provodnik
    {
        public static int y = 5;
        public static int x = 3;

        public static void Menu()
        {
            while(true)
            {
                string menu = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gg/меню.txt"));
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(menu);
                Console.SetCursorPosition(x, y);
                Console.WriteLine("=>");

                string[] Drives = Environment.GetLogicalDrives();
                foreach (string D in Drives)
                {
                    Console.SetCursorPosition(6, 5);
                    Console.WriteLine("Локальный диск ("+D+")");
                    Console.SetCursorPosition(6, 7);
                    Console.WriteLine("Локальный диск (D:\\)");
                }

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y != 5)
                        {
                            Console.SetCursorPosition(x, y);
                            y-=2;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (y != 7)
                        {
                            Console.SetCursorPosition(x, y);
                            y+=2;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (y == 5)
                        {
                            Console.SetCursorPosition(20, 5);
                            Console.WriteLine();
                        }
                        if (y == 7)
                        {
                            Suvtuvkar.Files();
                        }
                        break;
                }
            }
        }
    }
}
