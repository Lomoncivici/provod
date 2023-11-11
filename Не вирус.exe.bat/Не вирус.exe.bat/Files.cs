using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                        if (folder.Length < 57)
                        {
                            Console.SetCursorPosition(38, i++);
                            if ( i < 35)
                            {
                                Console.WriteLine(folder.Replace(Provodnik.PATH, "").Replace("\\", ""));
                            }
                        }
                        else if (folder.Length >= 57)
                        {
                            Console.SetCursorPosition(38, i++);
                            Console.WriteLine(folder.Remove(57, folder.Length - 57).Replace(Provodnik.PATH, "").Replace("\\", "") + " ...");
                        }
                        if (Provodnik.PATH.Length < 46)
                        {
                            Console.SetCursorPosition(41, 2);
                            Console.WriteLine("({0})", Provodnik.PATH);
                        }
                        else if (Provodnik.PATH.Length >= 46)
                        {
                            Console.SetCursorPosition(41, 2);
                            Console.WriteLine("({0})", Provodnik.PATH.Remove(46, Provodnik.PATH.Length - 46) + " ...");
                        }
                    }
                    foreach (string filename in allfiles)
                    {
                        if (filename.Length < 57)
                        {
                            Console.SetCursorPosition(38, i++);
                            if (i < 35)
                            {
                                Console.WriteLine(filename.Replace(Provodnik.PATH, "").Replace("\\", ""));
                            }
                            /*Console.WriteLine(i);*/
                        }
                        else if (filename.Length >= 57)
                        {
                            Console.SetCursorPosition(38, i++);
                            Console.WriteLine(filename.Remove(57, filename.Length - 57).Replace(Provodnik.PATH, "").Replace("\\", "") + " ...");
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
                        if (allfolders.Length != y - 4)
                        {
                            for (int g = 4; g < 34; g++)
                            {
                                Console.SetCursorPosition(35, g);
                                Console.WriteLine("                                                               ");
                            }
                            Provodnik.PATH = allfolders[y - 4];
                            Folder_Files();
                        }
                            
                        else if (allfolders.Length < y-4)
                        {
                            Provodnik.PATH = allfiles[y - 4];
                            Process.Start(new ProcessStartInfo { });
                        }
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

