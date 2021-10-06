using System;
using System.Collections.Generic;

namespace ParOuImper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 números e o resultado retornará a quantidade de pares e ímpares.");
            List<int> lista = new List<int>();
            int numero;
            int par = 0, impar = 0;
            while(lista.Count < 10){
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                lista.Add(numero);
            }
            foreach (int item in lista){
                if (item%2==0){
                    par++;
                } else {
                    impar++;
                }
            }
            string pp = par > 1 ? "es" : "";
            string ip = impar > 1 ? "es" : "";
            Console.WriteLine($"Você digitou {par} par{pp} e {impar} ímpar{ip}.");
        }
    }
}
