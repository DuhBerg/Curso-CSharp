using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CSharp_02
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Produto { get; set; }

        public OrderItem(int quantity, double price, Product produto)
        {
            Quantity = quantity;
            Price = price;
            Produto = produto;
        }


        public double subTotal()
        {
            return Quantity * Price;
        }


        public override string ToString()
        {
            return Produto.Nome +
                "," + "$" + Produto.Price + " " +
                "Quantity: " + Quantity +
                "," + "SubTotal: " + subTotal();
        }
    }
}
