using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Не_вирус.exe.bat
{
    internal class Suvtuvkar
    {
        public static void Files()
        {

            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            Console.CursorVisible = false;
            string[] bear0 = {
                " ▄▀ ▄▀      ▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄  ",
                "  ▀  ▀      █▒▒░░░░░░░░░▒▒█",
                "█▀▀▀▀▀█▄     █░░█░░░░░█░░█",
                "█░░░░░█ █ ▄▄  █░░░▀█▀░░░█  ▄▄ ",
                "▀▄▄▄▄▄▀▀ █░░█ ▀▄░░░░░░░▄▀ █░░█",
                "------------------------------",
            };
            string[] bear1 = {
                " █  █       ▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄  ",
                "  ▀  ▀      █▒▒░░░░░░░░░▒▒█",
                "█▀▀▀▀▀█▄     █░░█░░░░░█░░█",
                "█░░░░░█ █ ▄▄  █░░░▀█▀░░░█  ▄▄ ",
                "▀▄▄▄▄▄▀▀ █░░█ ▀▄░░░░░░░▄▀ █░░█",
                "------------------------------",
            };
            string[] bear2 = {
                " ▄  ▄      ▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄  ",
                "  ▀  ▀      █▒▒░░░░░░░░░▒▒█",
                "█▀▀▀▀▀█▄     █░░█░░░░░█░░█",
                "█░░░░░█ █ ▄▄  █░░░▀█▀░░░█  ▄▄ ",
                "▀▄▄▄▄▄▀▀ █░░█ ▀▄░░░░░░░▄▀ █░░█",
                "------------------------------",
            };
            string[] bear3 = {
                "             ▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄  ",
                "  ▀  ▀      █▒▒░░░░░░░░░▒▒█",
                "█▀▀▀▀▀█▄     █░░▒░░░░░▒░░█",
                "█░░░░░█ █ ▄▄  █░░░▀█▀░░░█  ▄▄ ",
                "▀▄▄▄▄▄▀▀ █░░█ ▀▄░░░░░░░▄▀ █░░█",
                "------------------------------",
            };
            string[] moved = bear0;
            int animationFrame = 0;

            while (true)
            {

                for (int i = 0; i < moved.Length; i++)
                {
                    Console.SetCursorPosition(50, 10 + i);
                    Console.WriteLine(moved[i]);
                }

                if (true)
                {
                    animationFrame = (animationFrame + 1) % 6;

                    if (animationFrame == 0)
                    {

                        moved = bear0;
                    }
                    else if (animationFrame == 1)
                    {

                        moved = bear1;
                    }
                    else if (animationFrame == 2)
                    {

                        moved = bear2;
                    }
                    else if (animationFrame == 3)
                    {

                        moved = bear3;
                    }
                    else if (animationFrame == 4)
                    {

                        moved = bear2;
                    }
                    else if (animationFrame == 5)
                    {

                        moved = bear1;
                    }

                    Thread.Sleep(150);
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
