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
        public static string PATH = "";
        public static void Folder_Files()
        {
            string[] allFilesAndFolders = Directory.GetDirectories(PATH).Concat(Directory.GetFiles(PATH)).ToArray();
            while (true)
            {
                Provodnik.Menu();
                Provodnik.Drives();
                for (int i = 64; i - 64 < allFilesAndFolders.Length; i++)
                {
                    foreach (string folder in allFilesAndFolders)
                    {
                        if (folder.Length < 57)
                        {
                            if (i < 94 && y < 93)
                            {
                                Console.SetCursorPosition(38, i++);
                                Console.Write(folder.Replace(PATH, "").Replace("\\", ""));
                                Console.SetCursorPosition(78, i - 1);
                                Info(new FileInfo(PATH));
                            }
                            else if (i < Up_Down + 64 && y == 93 )
                            {
                                Console.SetCursorPosition(38, i++ - (Up_Down - 29));
                                Console.Write(folder.Replace(PATH, "").Replace("\\", "") + (i));
                                Console.SetCursorPosition(78, (i - 1) - (Up_Down - 29));
                                Info(new FileInfo(PATH));
                            }
                            else if (i < Up_Down + 64 && y == 64)
                            {
                                Console.SetCursorPosition(38, i++ + (Up_Down - 29));
                                Console.Write(folder.Replace(PATH, "").Replace("\\", "") + (i));
                                Console.SetCursorPosition(78, (i - 1) + (Up_Down - 29));
                                Info(new FileInfo(PATH));
                            }
                        }
                            else if (folder.Length > 57)
                            {
                                if (i < 94 && y < 93)
                                {
                                    Console.SetCursorPosition(38, i++);
                                    Console.WriteLine(folder.Remove(57, folder.Length - 57).Replace(PATH, "").Replace("\\", "") + " ...");
                                    Console.SetCursorPosition(78, i - 1);
                                    Info(new FileInfo(PATH));
                                }
                                else if (i < Up_Down + 93 && Up_Down + 30 > 94)
                                {
                                    Console.SetCursorPosition(38, i++ - (Up_Down - 29));
                                    Console.WriteLine(folder.Remove(57, folder.Length - 57).Replace(PATH, "").Replace("\\", "") + " ...");
                                    Console.SetCursorPosition(78, (i - 1) - (Up_Down - 29));
                                    Info(new FileInfo(PATH));
                                }
                            }
                            if (PATH.Length < 46)
                            {
                                Console.SetCursorPosition(41, 62);
                                Console.WriteLine("({0})", PATH);
                            }
                            else if (PATH.Length >= 46)
                            {
                                Console.SetCursorPosition(41, 62);
                                Console.WriteLine("({0})", PATH.Remove(46, PATH.Length - 46) + " ...");
                            }
                    }
                }
                Da();
            }
        }
        static int y = 64;
        static int Up_Down = 0;
        static void Da()
        {

            string[] allfiles = Directory.GetFiles(PATH);
            string[] allfolders = Directory.GetDirectories(PATH);
            while (true)
            {
                Console.SetCursorPosition(36, y);
                Console.WriteLine("=>");

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y - 64 != 0)
                        {
                            Console.SetCursorPosition(36, y);
                            Console.WriteLine("  ");
                            y--;
                            Up_Down--;
                            Console.WriteLine(Up_Down);
                        }
                        else if (Up_Down != 0)
                        {
                            Up_Down--;
                            Console.WriteLine(Up_Down);
                            Folder_Files();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (y - 63 != allfolders.Length + allfiles.Length && y - 64 != 29)
                        {
                            Console.SetCursorPosition(36, y);
                            Console.WriteLine("  ");
                            y++;
                            Up_Down++;
                            Console.WriteLine(Up_Down);
                        }
                        else if (Up_Down !=(allfolders.Length + allfiles.Length) - 1)
                        {
                            /*for (int i = 64; i -64 < 29; i++)
                            {
                                Console.SetCursorPosition(0, i);
                                Console.WriteLine("                             ");
                            }*/
                            Up_Down++;
                            Console.WriteLine(Up_Down);
                            Folder_Files();
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (allfolders.Length > Up_Down)
                        {
                            PATH = allfolders[Up_Down];
                            y = 64;
                            Up_Down = 0;
                            Folder_Files();
                        }
                        else if (allfolders.Length < Up_Down)
                        {
                            PATH = allfiles[(Up_Down) - allfolders.Length];
                            Process.Start(new ProcessStartInfo {FileName = PATH, UseShellExecute = true});
                        }
                        break;
                    case ConsoleKey.Escape:
                        Up_Down = 0;
                        y = 64;
                        Console.Clear();
                        Provodnik.Menu();
                        Provodnik.Drives();
                        Provodnik.Strelochki();
                        break;
                }
            }

        }
        static void Info(FileSystemInfo fsi)
        {
            Console.WriteLine("{0:D}", fsi.CreationTime);
        }
    }
}
