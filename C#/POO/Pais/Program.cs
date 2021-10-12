using System;

namespace Pais
{
    class Program
    {
        static void Main(string[] args)
        {
            Brasil brasil = new Brasil();
            Brasil colonia = new Brasil();
            Argentina argentina = new Argentina();
            brasil.saoIguais(colonia);
            brasil.saoIguais(argentina);
            brasil.eVizinho(argentina);
            brasil.densidadeDemografica();
            brasil.vizinhosEmComum(argentina);
            brasil.vizinhosEmComum(colonia);

        }
    }
}
