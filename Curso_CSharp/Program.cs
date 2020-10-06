using Curso_CSharp_02.Entities;
using System;

namespace Curso_CSharp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string Nome_Cliente = Console.ReadLine();
            Console.Write("Digite seu e-mail: ");
            string Email = Console.ReadLine();
            Console.Write("BirthDate(DD/MM/YYYY): ");
            string BirthDate = Console.ReadLine();
            Client cliente = new Client(Nome_Cliente,Email,BirthDate);

            Console.WriteLine("Enter Order Data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status,cliente);





            Console.WriteLine("How many products to this Order? ");
            int products = int.Parse(Console.ReadLine());
            for (int i = 0; i < products; i++)
            {
                Console.WriteLine("Product Name: ");
                string Product_Name = Console.ReadLine();
                Console.WriteLine("Product Price: ");
                double Product_Price = Double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());
                Product produto = new Product(Product_Name, Product_Price);
                OrderItem Order_item = new OrderItem(Quantity, Product_Price, produto);

                order.addItem(Order_item);

            }


            Console.WriteLine(order.ToString());


        }
    }
}
