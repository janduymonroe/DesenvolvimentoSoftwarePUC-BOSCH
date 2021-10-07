using System;
using System.Linq;

namespace SomaValoreArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros;
            Console.WriteLine("Esse programa imprime um array de 5 itens e a soma deles.");
            Console.Write("Digite uma sequência de 5 números com espaço entre eles: ");
            numeros = Console.ReadLine().Split();
            Console.WriteLine(value: $"Seu array é {string.Join(", ", numeros)}, e sua soma é {numeros.Sum(x=>int.Parse(x))}");

        }
    }
}
