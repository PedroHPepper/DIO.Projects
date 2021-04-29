using System;
using System.Collections.Generic;
using System.Linq;

namespace ComprasNoSupermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());

            List<string> listas = new List<string>();

            if (totalDeCasosDeTeste > 0)
            {
                for (int i = 0; i < totalDeCasosDeTeste; i++)
                {
                    List<string> lista = Console.ReadLine().Split(" ").ToList();

                    lista.Sort();
                    lista = lista.Distinct().ToList();
                    string novaLista = "";
                    for(int j = 0; j < lista.Count; j++)
                    {
                        if(j > 0)
                        {
                            novaLista += " ";
                        }
                        novaLista += lista[j];
                    }

                    listas.Add(novaLista);
                }
                for (int i = 0; i < totalDeCasosDeTeste; i++)
                {
                    Console.WriteLine(listas[i]);
                }

            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
