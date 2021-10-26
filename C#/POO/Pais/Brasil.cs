using System;
using System.Collections.Generic;

namespace Pais {

    class Brasil : Pais{

        public Brasil()
        {
            codigoISO = "076";
            nome = "Brasil";
            populacao = 202768562;
            dimensao = 8515767.049;
            vizinhos = new List<string>()
            {"Argentina", "Bolívia", "Colômbia", "Guiana Francesa", "Guiana", "Paraguai", "Peru", "Suriname",
             "Uruguai", "Venezuela"};
        }

       
    }
}