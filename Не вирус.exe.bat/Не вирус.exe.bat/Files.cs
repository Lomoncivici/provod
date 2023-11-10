using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Не_вирус.exe.bat
{
    internal class Filess
    {
        public static void Folder_Files()
        {
            while (true)
            {
                string[] allfiles = Directory.GetFiles(Provodnik.PATH);
                string[] allfolders = Directory.GetDirectories(Provodnik.PATH);
                for (int i = 4; i - 4 < allfolders.Length; i++)
                {
                    foreach (string folder in allfolders)
                    {
                        if (folder.Length < 55)
                        {
                            Console.SetCursorPosition(38, i++);
                            if ( i < 35)
                            {
                                Console.WriteLine(folder);
                            }
                        }
                        else if (folder.Length > 55)
                        {
                            Console.SetCursorPosition(38, i++);
                            Console.WriteLine(folder.Remove(55, folder.Length - 55) + " ...");
                        }
                    }
                    foreach (string filename in allfiles)
                    {
                        if (filename.Length < 55)
                        {
                            Console.SetCursorPosition(38, i++);
                            if (i < 35)
                            {
                                Console.WriteLine(filename);
                            }
                        }
                        else if (filename.Length > 55)
                        {
                            Console.SetCursorPosition(38, i++);
                            Console.WriteLine(filename.Remove(55, filename.Length - 55) + " ...");
                        }
                    }
                }
                Da();
            }
        }
        static void Da()
        {
            int y = 4;

            string[] allfiles = Directory.GetFiles(Provodnik.PATH);
            string[] allfolders = Directory.GetDirectories(Provodnik.PATH);
            while (true)
            {
                Console.SetCursorPosition(36, y);
                Console.WriteLine("=>");

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y != 4)
                        {
                            Console.SetCursorPosition(36, y);
                            Console.WriteLine("  ");
                            y--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (y != allfolders.Length + allfiles.Length +3 && y != 33)
                        {
                            Console.SetCursorPosition(36, y);
                            Console.WriteLine("  ");
                            y++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        for (int g = 4; g < 34; g++)
                        {
                            Console.SetCursorPosition(35, g++);
                            Console.WriteLine("*                                                              ");
                            Console.SetCursorPosition(35, g-=1);
                            Console.WriteLine("*                                                              ");
                        }
                        Provodnik.PATH = allfolders[y - 4];
                        Folder_Files();
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Provodnik.Menu();
                        break;
                }
            }
            
        }
    }
}

