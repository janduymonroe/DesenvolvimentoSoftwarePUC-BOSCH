using System;
using System.Collections.Generic;

namespace Pais {

    abstract class Pais{

     
            public string codigoISO { get; set; }
            public string nome { get; set; }
            public int populacao { get; set; }
            public double dimensao { get; set; }
            public List<string> vizinhos { get; set; }

            public void saoIguais(Pais outroPais){
                if (this.codigoISO == outroPais.codigoISO){
                    System.Console.WriteLine("Representam o mesmo país");
                } else {
                    System.Console.WriteLine("NÃO representam o mesmo país");
                }
            }

            public void eVizinho(Pais outroPais){
                if (this.vizinhos.Contains(outroPais.nome)){
                    System.Console.WriteLine("São vizinhos.");
                } else {
                    System.Console.WriteLine("NÃO são vizinhos.");
                }
            }

            public void densidadeDemografica(){
                System.Console.WriteLine((this.populacao / this.dimensao).ToString("0.00"));
            }

            public void vizinhosEmComum (Pais outroPais){
                List<string> vizinhosEmComum = new List<string>();
                foreach(string pais in this.vizinhos){
                    if (outroPais.vizinhos.Contains(pais)){
                        vizinhosEmComum.Add(pais);
                    } else {
                        continue;
                    }
                }
                System.Console.WriteLine(String.Join(", ", vizinhosEmComum));
            }
  
        

    }
}