using Curso_CSharp_02.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso_CSharp_02
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client cliente { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(OrderStatus status, Client cliente)
        {
            this.Moment = DateTime.Now;
            this.Status = status;
            this.cliente = cliente;
        }



        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.subTotal();
            }
            return total;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + cliente);
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
