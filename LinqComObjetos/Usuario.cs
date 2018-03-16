using System;
namespace LinqComObjetos
{
    public class Usuario
    {
        public string nome { get; set; }
        public string email { get; set; }

        public Usuario(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
    }
}
