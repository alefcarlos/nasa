using System;

namespace Sonda.Nasa.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = new Planalto(5, 5);

            var sonda1 = area.AddSonda(new Sonda(1, 2, EApontamentos.S));
            var sonda2 = area.AddSonda(new Sonda(3, 3, EApontamentos.E));

            // sonda1.Acao(EAcao.L);
            sonda1.Acao(EAcao.M);
            // sonda1.Acao(EAcao.L);
            // sonda1.Acao(EAcao.M);
            // sonda1.Acao(EAcao.L);
            sonda1.Acao(EAcao.M);
            // sonda1.Acao(EAcao.L);
            sonda1.Acao(EAcao.M);
            sonda1.Acao(EAcao.M);
            sonda1.Acao(EAcao.M);
            sonda1.Acao(EAcao.M);

            sonda2.Acao(EAcao.M);
            sonda2.Acao(EAcao.M);
            sonda2.Acao(EAcao.R);
            sonda2.Acao(EAcao.M);
            sonda2.Acao(EAcao.M);
            sonda2.Acao(EAcao.R);
            sonda2.Acao(EAcao.M);
            sonda2.Acao(EAcao.R);
            sonda2.Acao(EAcao.R);
            sonda2.Acao(EAcao.M);
            
            //validar
            Console.WriteLine(sonda1.ToString());
            Console.WriteLine(sonda2.ToString());
        }
    }
}
