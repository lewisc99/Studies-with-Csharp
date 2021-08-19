using System.IO;
using System;
using System.Collections.Generic;
using teste.Entities;

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
            string status = Console.ReadLine();
            Console.Write("How many itens to this order? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            for (int i = 0;i < n; i++)
            {
                Console.Write("Product Name: ");
                string pName = Console.ReadLine();
                Console.Write("Product Name: ");
                double pPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int  quantity = int.Parse(Console.ReadLine());

                Product p = new Product(pName,pPrice);
                OrderItem OrderQ = new OrderItem(quantity, pPrice);

                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");






        }
    }
}
