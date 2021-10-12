using System;

namespace Contador {

    class Contador{

        public int valor { get; set; }

        public void zerar(){
            Console.WriteLine("Contador zerado.");
            valor = 0;
        }

        public void incrementar(){
            valor++;
            Console.WriteLine($"Contador incrementado. Valor {valor}.");
            
        }

        public void retornaValor(){
            valor--;
            Console.WriteLine($"Contador decrescido.  Valor {valor}.");
            
        }

        public override string ToString()
        {
            return $"O valor do seu contador é {valor}.";
        }

    }
}