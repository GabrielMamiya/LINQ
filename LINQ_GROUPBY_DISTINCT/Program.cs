using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_GROUPBY_DISTINCT
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] listaNumeros = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

            //DISTINCT
            // ele pega um numero de cada.
            var listaFiltrada = listaNumeros.Distinct().OrderBy(a => a).Select(a => a);

            //GROUPBY
            // precisa usar item.key
            var listaFiltrada = listaNumeros.OrderBy(a => a).GroupBy(a => a).Select(a => a);

            foreach(var item in listaFiltrada)
            {
                Console.WriteLine(item.Key);
            }


        }
    }
}
