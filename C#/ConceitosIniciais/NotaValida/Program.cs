using System;

namespace NotaValida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("São considerados válidos valores maiores que 7.");
            double numero = 0;
            while (numero<=7){
                Console.Write("Digite uma nota válida: ");
                numero = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"Parabéns {numero} é uma nota válida.");
        }
    }
}
