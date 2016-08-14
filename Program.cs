using System;

namespace SpiralPrint
{
    public class SpiralPrint
    {
        public static void Main(String[] args)
        {
            int n = 2, i, side = n, x = 0, y = 0;
            int[][] tab = new int[n][];


            i = n * n;
            for (int l = 0; l < n; l++)
            {
                tab[l] = new int[n];
            }
            while (i >= 1)
            {
                for (int j = 0; j < side; j++)
                    tab[x][y++] = i--;
                x++;
                y--;
                if (i >= 1)
                {
                    for (int j = 0; j < side - 1; j++)
                        tab[x++][y] = i--;
                    x--;
                    y--;
                }
                if (i >= 1)
                {
                    for (int j = 0; j < side - 1; j++)
                        tab[x][y--] = i--;
                    x--;
                    y++;
                }
                if (i >= 1)
                {
                    for (int j = 0; j < side - 2; j++)
                        tab[x--][y] = i--;
                    y++;
                    x++;
                    side = side - 2;

                }
            }

            for (i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (tab[i][j] < 10)
                        Console.Write(" ");
                    Console.Write(tab[i][j] + " ");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }

}
