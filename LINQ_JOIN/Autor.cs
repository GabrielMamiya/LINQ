using System;
namespace LINQ_JOIN
{
    public class Autor
    {

        public int ID { get; set; }
        public string nome { get; set; }

        public Autor(int ID, string nome)
        {
            this.ID = ID;
            this.nome = nome;
        }
    }
}
