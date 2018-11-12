using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.model
{
    public class Contato
    {
        public Contato()
        {

        }

        public Contato(string nome, string email, int idade)
        {
            this.Nome = nome;
            this.Email = email;
            this.Idade = idade;   
        }
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public int Idade { get; set; }
    }
}
