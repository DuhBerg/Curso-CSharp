using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CSharp_02
{
    class Product
    {
        public string Nome { get; set; }
        public double Price { get; set; }

        public Product(string nome, double price)
        {
            this.Nome = nome;
            this.Price = price;
        }
    }
}
