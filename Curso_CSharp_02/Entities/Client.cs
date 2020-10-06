using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CSharp_02.Entities
{
    class Client
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }

        public Client(string nome, string email, string birthdate)
        {
            this.Nome = nome;
            this.Email = email;
            this.BirthDate = birthdate;
        }

        public override string ToString()
        {
            return Nome + "," + Email + "," + BirthDate;
        }
    }
}
