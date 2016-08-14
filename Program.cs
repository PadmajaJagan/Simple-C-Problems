using System;

namespace CDS
{
    class Program
    {
        public class XArray
        {
            static int[] FirstDS;
            static int midIndex;

            public XArray(int limit)
            {
                FirstDS = new int[limit];
                midIndex = FirstDS.Length / 2;
            }

            public static void beforeMid()
            {
                for (int i = 0; i <= midIndex; i++)
                {
                    int j;
                    bool mid = false;
                    if (i == midIndex)
                        mid = true;
                    for (j = 0; j < i; j++)
                        Console.Write(" ");
                    FirstDS[i] = i;

                    if (mid)
                    {
                        Console.WriteLine(FirstDS[i]);
                        break;
                    }

                    Console.Write(FirstDS[i]);

                    for (int k = i; k < FirstDS.Length - i - 1; k++)
                        Console.Write(" ");
                    Console.WriteLine(FirstDS[i]);


                }

            }

            public static void afterMid()
            {
                int j;
                for (int i = midIndex + 1; i < FirstDS.Length; i++)
                {
                    for (j = 0; j < FirstDS.Length - i; j++)
                        Console.Write(" ");
                    Console.Write(i);

                    for (int k = j + 1; k < i; k++)
                        Console.Write(" ");
                    Console.WriteLine(i.ToString());
                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Datasructures using C#");
            Console.Write("Enter Array Limit : ");
            XArray newArray = new XArray(Int32.Parse(Console.ReadLine()));
            XArray.beforeMid();
            XArray.afterMid();
            Console.ReadKey();
        }
    }
}
