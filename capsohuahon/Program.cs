using System;

namespace test
{
    class Program
    {
        static int input()
        {
            int N;
            do
            {
                Console.WriteLine("Input N");
                N = Convert.ToInt32(Console.ReadLine());
            } while (N < 999 || N > 10000);
            return N;

        }

        public static int sumdivisor(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;

                }
            }
            return sum;
        }

        public static int sumdivisor2(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;

                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int n = input();
            int[] friendly = new int[n];
            int[] huahon = new int[n * 2];
            for (int i = 2; i < n; i++)
            {
                int STT = sumdivisor(i);
                if ((sumdivisor(STT) == i) && (STT != i))
                {
                    if (friendly[i] != 1 || friendly[STT] != 1)
                    {
                        Console.WriteLine(STT + " " + i);
                        friendly[i] = 1;
                        friendly[STT] = 1;
                    }

                }
            }
            Console.WriteLine("So Hua Hon:");
            for (int i = 2; i < n; i++)
            {
                int SHH = sumdivisor(i) - 1;
                int SHH2 = i + 1;
                if (SHH2 == sumdivisor(SHH))
                {
                    if (huahon[i] != 1 || huahon[SHH] != 1)
                    {
                        if (SHH >= n)
                        {
                            break;
                        }
                        Console.WriteLine(i + " " + SHH);
                        huahon[i] = 1;
                        huahon[SHH] = 1;
                    }

                }
            }

        }
    }
}