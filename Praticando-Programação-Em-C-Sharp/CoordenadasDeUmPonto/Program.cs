using System;

namespace CoordenadasDeUmPonto
{
    class Program
    {
        static void Main(string[] args)
        {
            //implemente sua solução aqui
            string[] input = Console.ReadLine().Split();
            double eixoX = double.Parse(input[0]);
            double eixoY = double.Parse(input[1]);

            if (eixoX > 0 && eixoY > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (eixoX < 0 && eixoY > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (eixoX < 0 && eixoY < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (eixoX > 0 && eixoY < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (eixoX == 0 && eixoY == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (eixoX == 0 && eixoY != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (eixoX != 0 && eixoY == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
