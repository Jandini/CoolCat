using System;

namespace CoolCat
{
    class Program
    {

        static readonly string[] coolCat = new string[]
        {
            "  bb          bb  ",
            "  byb        byb  ",
            "  bbyb      bybb  ",
            "  b byb    byb b  ",
            "  b byb    byb b  ",
            "  b byyb  byyb b  ",
            "  b byyybbyyyb b  ",
            "  b byyyyyyyyb b  ",
            "  bbyyyyyyyyyybb  ",
            "  byyyyyyyyyyyyb  ",
            "  byyywwyywwyyyb  ",
            "  bbbbbbyybbbbbb  ",
            "  bbbbbbbbbbbbbb  ",
            "  bbbbbbwwbbbbbb  ",
            "  bybbbwwwwbbbyb  ",
            "  byyyywbbwyyyyb  ",
            " bwwwwwwbbwwwwwwb ",
            "bwwwwwwbwwbwwwwwwb",
            "bbbbwwwwbbwwwbbbbb",
            "  bybbbbbbbbbbyb  ",
            " byyy        yyyb ",
            "byyyy        yyyyb",
            "byyby        ybyyb",
            " byby        ybyb ",
            "  bbyy      yybb  ",
            "   byybbbbbbyyb   ",
            "  byyb      byyb  ",
            " b  b        b  b ",
            " bbbb        bbbb ",
        };



        static void DrawCat(string line)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - line.Length, Console.CursorTop);            

            foreach (var character in line)
            {
                var color = character switch
                {
                    'b' => ConsoleColor.Black,
                    'y' => ConsoleColor.DarkYellow,
                    'w' => ConsoleColor.White,
                    _ => ConsoleColor.Gray,
                };

                Console.BackgroundColor = color;
                Console.Write("  ");
            }
          
            Console.WriteLine();
        }

        static void Main()
        {               
            Console.Title = "Cool Cat";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.CursorTop = Console.WindowHeight / 2 - coolCat.Length / 2;

            foreach (var line in coolCat)
                DrawCat(line);

            Console.ReadLine();
        }
    }
}
