using System;

namespace AumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, novoSalario, percentual;
            salario = Convert.ToDouble(Console.ReadLine());

            //insira os valores corretos de acordo com o enunciado
            if (salario < 0.00)
            {
                return;
            }
            if (salario >= 0.00 && salario <= 400.00)
            {
                percentual = 0.15;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;

            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                percentual = 0.12;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                percentual = 0.10;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                percentual = 0.07;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;
            }
            else
            {
                percentual = 0.04;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;
            }
            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual * 100);
        }
    }
}
