using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            while (numeros.Lenght() < 3){
                Console.Write("Escreva um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                if(numero > numeros[0])
                    numeros[0] = numero;
                else
                {
                    numeros[1] = numero;
                }
                Console.WriteLine(numeros);
            }

        }
    }
}
