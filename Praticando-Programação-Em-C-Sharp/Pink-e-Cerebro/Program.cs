using System;

namespace Pink_e_Cerebro
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string stringN = Console.ReadLine();
            string[] numStringList = stringN.Split(' ');
            int div2 = 0;
            int div3 = 0;
            int div4 = 0;
            int div5 = 0;

            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(numStringList[i]);

                if (num % 2 == 0)
                {
                    div2 += 1;
                }

                if (num % 3 == 0)
                {
                    div3 += 1;
                }

                if (num % 4 == 0)
                {
                    div4 += 1;
                }

                if (num % 5 == 0)
                {
                    div5 += 1;
                }
            }

            string result = "";
            result += $"{div2} Multiplo(s) de 2\n";
            result += $"{div3} Multiplo(s) de 3\n";
            result += $"{div4} Multiplo(s) de 4\n";
            result += $"{div5} Multiplo(s) de 5\n";
            Console.WriteLine(result.ToString());
        }
    }
}
