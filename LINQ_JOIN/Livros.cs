using System;
namespace LINQ_JOIN
{
    public class Livros
    {

        public int ID { get; set; }
        public int autorID { get; set; } 
        public string titulo { get; set; }
        public string anoDePublicacao { get; set; }

        public Livros(int ID, int autorID, string titulo, string anoDePublicacao)
        {
            this.ID = ID;
            this.autorID = autorID;
            this.titulo = titulo;
            this.anoDePublicacao = anoDePublicacao;
        }
    }
}
