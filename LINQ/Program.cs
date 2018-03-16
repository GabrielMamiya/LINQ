using System;
using System.Linq;

namespace LINQ
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //lambda

            //(entrada) => (expressao)

            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //"A" representa a entrada de dados
            //var listaFiltrada = lista.Where(a => a > 10).Select(a => a);

            //OU ORDERBYDESC = decrescente
            var listaFiltrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }
        }
    }
}
