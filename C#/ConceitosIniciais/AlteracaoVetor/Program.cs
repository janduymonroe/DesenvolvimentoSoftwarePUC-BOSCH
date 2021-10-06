using System;

namespace AlteracaoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor =0, indice = 0;
            int[] vetor = new int[10];
            while(true){
                if(valor == -1){
                    break;
                } else {
                    try{
                        Console.WriteLine($"O vetor é {String.Join(",",vetor)}");
                        System.Console.Write("Digite o valor que deseja inserir ou digite -1 para sair: ");
                        valor = Convert.ToInt32(Console.ReadLine());
                        System.Console.Write("Em qual indíce deseja inserir o valor: ");
                        indice = Convert.ToInt32(Console.ReadLine());
                        vetor[indice] = valor;
                    } catch (Exception){
                        Console.WriteLine("Você precisa digitar um número de 0 a 9 para índice.");
                    }
                }

            }
        }
    }
}
