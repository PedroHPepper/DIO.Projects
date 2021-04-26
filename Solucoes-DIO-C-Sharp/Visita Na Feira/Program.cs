using System;

namespace Visita_Na_Feira
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;


            string input = Console.ReadLine();

            a = Convert.ToInt32(input.Split(" ")[0]);
            b = Convert.ToInt32(input.Split(" ")[1]);

            x = a + b; //complete o código de acordo com o cálculo esperado

            Console.WriteLine("X = {0}", x);
        }
    }
}
