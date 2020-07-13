using Microsoft.VisualBasic;
using System;
using Exercio01Fixacao.Entities;
using System.Data;
using Exercio01Fixacao.Entities.Enums;

namespace Exercio01Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data");
            Console.Write("Enter name: ");
            string ClientName = Console.ReadLine();
            Console.Write("Enter Email: ");
            string ClientEmail = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYY): ");
            DateTime Birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(ClientName, ClientEmail, Birthdate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product Price: ");
                double prodPrice = double.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);

                Console.Write("Quantity: ");
                int prodQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(prodQuantity, prodPrice, product);
                order.AddItem(orderItem);

            }

            Console.WriteLine("");
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);






        }
    }
}
