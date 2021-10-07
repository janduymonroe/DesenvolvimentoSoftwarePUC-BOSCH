using System;
using System.Linq;

namespace VerificarMegaSena
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numerosSorteados = {15, 37, 45, 60, 17, 05};
            int[] numerosEscolhidos = new int[6];
            Console.Write("Digite os números escolhidos separados por espaço: ");
            string[] recebeNumeros = Console.ReadLine().Split();
            int contador = 0;
            foreach(string item in recebeNumeros){
                numerosEscolhidos[contador] = Convert.ToInt32(item);
            }
            if (numerosSorteados.Any(item => numerosEscolhidos.Contains(item))){
                System.Console.WriteLine("Você é um novo milionário.");
            } else {
                System.Console.WriteLine("Você precisa de mais sorte.");
            }
        }
    }
}
