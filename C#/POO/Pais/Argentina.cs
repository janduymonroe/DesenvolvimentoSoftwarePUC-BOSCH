using System;
using System.Collections.Generic;

namespace Pais {

    class Argentina : Pais{

        public Argentina()
        {
            codigo = "032";
            nome = "Argentina";
            populacao = 45605826;
            dimensao = 2780400.00;
            vizinhos = new List<string>()
            {"Bolívia", "Brasil", "Chile", "Paraguai", "Uruguai"};
        }

       
    }
}