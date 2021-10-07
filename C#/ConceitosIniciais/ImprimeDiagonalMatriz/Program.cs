using System;

namespace ImprimeDiagonalMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esse programa cria uma matriz 4x4 e imprime sua diagonal.");
            string[] ordem = {"primeira", "segunda", "terceira", "quarta"};
            int[,] matriz = new int[4,4];
            string[] linhaProvisoria;
            int cont1 = 0, cont2 = 0, cont3 = 0;
            while(true){
                Console.Write($"Escreva a {ordem[cont1]} linha da matriz, com espaço entre os números: ");
                cont1++;
                linhaProvisoria = Console.ReadLine().Split();
                foreach(string numero in linhaProvisoria){

                    matriz[cont2,cont3] = Convert.ToInt32(numero);
                    cont3++;
                }
                cont2++;
                cont3 = 0;
                if (cont1 == 4){
                    break;
                }
            }
            
            Console.WriteLine("A diagonal da matriz é: ");
            Console.Write($"{matriz[0,0]}\n\t{matriz[1,1]}\n\t\t{matriz[2,2]}\n\t\t\t{matriz[3,3]}");
            
        }
    }
}
