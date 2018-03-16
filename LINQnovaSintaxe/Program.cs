using System;
using System.Linq;

namespace LINQ
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            var listaFiltrada = from a in lista where a > 10 orderby a select a;

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }
        }
    }
}
