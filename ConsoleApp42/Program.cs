using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;
            Console.SetCursorPosition(x, y);
            int p = Console.WindowWidth-1;
            

            while (true)
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (y == 0)
                        Console.SetCursorPosition(x, y);
                    else
                        Console.SetCursorPosition(x, y -= 1);
                }
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                        Console.SetCursorPosition(x, y += 1);
                }
                if (keyinfo.Key == ConsoleKey.RightArrow)
                {
                    if (x == p)
                        Console.SetCursorPosition(x, y);
                    else
                        Console.SetCursorPosition(x += 1, y);
                }
                if (keyinfo.Key == ConsoleKey.LeftArrow)
                {
                    if (x == 0)
                        Console.SetCursorPosition(x, y);
                    else
                        Console.SetCursorPosition(x -= 1, y);
                }
                Console.WriteLine("*");
            }
        }
    }
}
