using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqComObjetos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Usuario> usuario = new List<Usuario>();
            usuario.Add(new Usuario("Jose", "jose@gmail.com"));
            usuario.Add(new Usuario("Maria", "maria@hotmail.com"));
            usuario.Add(new Usuario("Joao", "joao@ig.com"));
            usuario.Add(new Usuario("Felipe", "felipe@gmail.com"));
            usuario.Add(new Usuario("Elias", "elias@gmail.com"));

            var listaFiltrada = usuario.Where(a => a.email.Contains("@gmail.com")).OrderBy(a => a.nome).Select(a => a.nome);

            foreach(var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }
        }
    }
}
