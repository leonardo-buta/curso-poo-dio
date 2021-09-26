using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade {get; set; }

        public string Documento { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}