using System;

namespace CoolCat
{
    class Program
    {

        static void DrawCat(string line, bool isLast = false)
        {

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

            if (!isLast)
                Console.WriteLine();
        }

        static void Main(string[] args)
        {

            DrawCat("  bb          bb  ");
            DrawCat("  byb        byb  ");
            DrawCat("  bbyb      bybb  ");
            DrawCat("  b byb    byb b  ");
            DrawCat("  b byb    byb b  ");
            DrawCat("  b byyb  byyb b  ");
            DrawCat("  b byyybbyyyb b  ");
            DrawCat("  b byyyyyyyyb b  ");
            DrawCat("  bbyyyyyyyyyybb  ");
            DrawCat("  byyyyyyyyyyyyb  ");
            DrawCat("  byyywwyywwyyyb  ");
            DrawCat("  bbbbbbyybbbbbb  ");
            DrawCat("  bbbbbbbbbbbbbb  ");
            DrawCat("  bbbbbbwwbbbbbb  ");
            DrawCat("  bybbbwwwwbbbyb  ");
            DrawCat("  byyyywbbwyyyyb  ");
            DrawCat(" bwwwwwwbbwwwwwwb ");
            DrawCat("bwwwwwwbwwbwwwwwwb");
            DrawCat("bbbbwwwwbbwwwbbbbb");
            DrawCat("  bybbbbbbbbbbyb  ");
            DrawCat(" byyy        yyyb ");
            DrawCat("byyyy        yyyyb");
            DrawCat("byyby        ybyyb");
            DrawCat(" byby        ybyb ");
            DrawCat("  bbyy      yybb  ");
            DrawCat("   byybbbbbbyyb   ");
            DrawCat("  byyb      byyb  ");
            DrawCat(" b  b        b  b ");
            DrawCat(" bbbb        bbbb ");
            DrawCat("                  ", true);

            Console.ReadLine();
        }
    }
}



