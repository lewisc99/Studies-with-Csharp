using System.IO;
using System;
using System.Collections.Generic;
using teste.Entities;
using teste.Entities.enums;

/* Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um
sumário do pedido conforme exemplo, 
foi usado enumerações e composicação, para melhor navegação e facilidade durante o uso do programa*/

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.WriteLine("Enter client  data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            
            Client cliente = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, cliente);
            Console.Write("How many itens to this order? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product Name: ");
                string pName = Console.ReadLine();
                Console.Write("Product Price: ");
                double pPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int  quantity = int.Parse(Console.ReadLine());

                Product p = new Product(pName,pPrice);
                OrderItem OrderQ = new OrderItem(quantity, pPrice,p);
                order.addItem(OrderQ);

                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");



            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);



        }
    }
}
