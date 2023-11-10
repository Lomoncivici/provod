namespace Не_вирус.exe.bat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(146, 36);
            Console.Title = "Проводник";
            Console.CursorVisible = false;
            Provodnik.Menu();
        } 
    }
}