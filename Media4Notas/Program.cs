using System;
using System.Collections.Generic;
using System.Linq;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> notas = new List<int>();
            int ordem = 1;
            while ( notas.Count < 4){
                Console.Write($"Digite a {ordem}ª nota: ");
                int nota = Convert.ToInt32(Console.ReadLine());
                notas.Add(nota);
                ordem++;
            }
            double media = (double)notas.Sum()/4;
            string situacao = Situacao(media);
            Console.WriteLine($"A sua situação é {situacao} com média {media}.");
        }

        public static string Situacao (double media){
            if (media < 7){
                return "Reprovado";
            } else {
                return "Aprovado";
            }
        }
    }
}
