using System;
using System.Collections.Generic;

namespace OrdenaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<int> lista = new List<int>();
            string[] ordens = {"primeiro", "segundo", "terceiro"};
            int numero;
            foreach (string ordem in ordens){
                Console.Write($"Escreva o {ordem} número que deseja ordenar: ");
                numero = Convert.ToInt32(Console.ReadLine());
                lista.Add(numero);
            }
            lista.Sort();
            Console.WriteLine("A sua sequência de números ordenada é: {0}, {1}, {2}", lista[0], lista[1], lista[2]);
        }
    }
}
