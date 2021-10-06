using System;

namespace ImprimirVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int contador = 0, numero = 0;

            while(contador<9){        
                Console.Write("Digite um número para compor o vetor: ");
                numero = Convert.ToInt32(Console.ReadLine());
                vetor[contador] = numero;
                contador++;
            }
            foreach (int item in vetor){
                System.Console.WriteLine(item);
            }

        }
    }
}
