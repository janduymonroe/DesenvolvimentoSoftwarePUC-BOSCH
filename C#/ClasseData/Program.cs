using System;
using System.Linq;
using System.Collections.Generic;
namespace ClasseData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o formato de data que deseja retornar: ");
            string rawData = Console.ReadLine();
            Data data = new Data();
            data.DefineFormato(rawData);
                      

            
        }

      
    }
}
