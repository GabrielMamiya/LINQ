using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_JOIN
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            List<Autor> listaDeAutores = new List<Autor>();

            listaDeAutores.Add(new Autor(1, "Leonardo"));
            listaDeAutores.Add(new Autor(2, "Maria Maria"));
            listaDeAutores.Add(new Autor(3, "Joseph"));

            List<Livros> listaDeLivros = new List<Livros>();

            listaDeLivros.Add(new Livros(1, 2, "Amor Amado", "2000"));
            listaDeLivros.Add(new Livros(2, 2, "Bem Amado", "2005"));
            listaDeLivros.Add(new Livros(3, 3, "Um Espiao em Washington", "2007"));
            listaDeLivros.Add(new Livros(4, 1, "A Vida na Terra", "2010"));

            var listaJoin = from livros in listaDeLivros join autor in listaDeAutores on livros.autorID equals autor.ID select new {livros, autor};

            foreach(var item in listaJoin)
            {
                Console.WriteLine("Livro: " + item.livros.titulo + " - Autor: " + item.autor.nome);
            }

        }
    }
}
