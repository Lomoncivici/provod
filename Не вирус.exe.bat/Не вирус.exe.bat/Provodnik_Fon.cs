using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Не_вирус.exe.bat
{
    internal class Provodnik
    {
        public static string PATH = "";

        public static void Menu()
        {
            int y = 65;
            Console.CursorVisible = false;
            while (true)
            {
                string menu = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gg/меню.txt"));
                Console.SetCursorPosition(0, 60);
                Console.WriteLine(menu);

                Console.SetCursorPosition(36, 62);
                Console.WriteLine("Путь:");

                DriveInfo[] allDrives = DriveInfo.GetDrives();
                for (int i = 64; i - 64 < allDrives.Length; i++)
                {
                    foreach (DriveInfo driver in allDrives)
                    {
                        Console.SetCursorPosition(4, i += 1);
                        Console.WriteLine("Диск ({0}) | Тип: {1}", driver.Name.Remove(2,1), driver.DriveType);


                        if (driver.IsReady == true)
                        {
                            Console.SetCursorPosition(2, i += 1);
                            Console.WriteLine("Файловая система: {0}", driver.DriveFormat);

                            Console.SetCursorPosition(2, i += 1);
                            Console.WriteLine("Свободно гигабайт: [{0,0}]", (((driver.TotalFreeSpace / 1024)) / 1024) / 1024);

                            Console.SetCursorPosition(2, i += 1);
                            Console.WriteLine("Всего гигабайт: [{0,0}]", (((driver.TotalSize / 1024)) / 1024) / 1024);
                            Console.SetCursorPosition(1, i += 1);
                            Console.WriteLine("---------------------------------");
                        }
                    }
                }

                Console.SetCursorPosition(2, y);
                Console.WriteLine("=>");

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y != 65)
                        {
                            Console.SetCursorPosition(2, y);
                            y -= 5;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (y != 60 + (5 * allDrives.Length))
                        {
                            Console.SetCursorPosition(2, y);
                            y += 5;
                        }
                        break;
                    case ConsoleKey.Enter:
                        PATH = allDrives[(y - 60)/5-1].Name;
                        Filess.Folder_Files();
                        break;
                }
            }
        }
    }
}
