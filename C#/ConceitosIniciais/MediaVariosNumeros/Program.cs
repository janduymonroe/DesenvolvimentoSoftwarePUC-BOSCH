using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaVariosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você pode digitar uma sequência de números para obter a média entre eles.");
            Console.WriteLine("Para encerrar a execução e calcular a média digite -1.");
            List<double> lista = new List<double>();
            double numero = 0;
            double media;
            while(numero != -1){
                Console.Write("Digite um número: ");
                numero = Convert.ToDouble(Console.ReadLine());
                lista.Add(numero);
            }
            media = lista.Sum()/lista.Count;
            Console.WriteLine($"A média dos números digitados é {media}.");
            
        }
    }
}
