using System;

namespace SomaNPrimeirosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade dos N primeiros números você deseja somar: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int soma = 0, numero = 0;
            while(numero<n){
                numero++;
                soma = soma + numero;
            }
            Console.WriteLine($"A soma dos {n} primeiros números é {soma}.");

        }
    }
}
