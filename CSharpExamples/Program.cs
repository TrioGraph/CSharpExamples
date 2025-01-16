using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "HP Laptop", "HP Laptop 12345");
            p1.GetData();


            Product p2 = new Product(2, "Dell Laptop", "Dell Laptop 3456");
            p2.GetInfo();

            Console.WriteLine("Enter how many objects want to create: ");
            int numOfObjects = int.Parse(Console.ReadLine());
            
            int counter = 0;
            Product[] p3 = new Product[numOfObjects];
            do
            {
                int productId;
                string productName;
                string productDescription;

                Console.WriteLine($"Enter {counter} Product");


                Console.WriteLine("Enter Product Id:");
                productId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Product Name:");
                productName = Console.ReadLine();

                Console.WriteLine("Enter Product Description:");
                productDescription = Console.ReadLine();


                p3[counter] = new Product(productId, productName, productDescription);
                Console.WriteLine($"Object {counter} : {p3.ToString() }");
                counter++;
            } while (counter < numOfObjects);



            Console.WriteLine("Printing all data");
            for (int i = 0; i < numOfObjects; i++)
            {
                Console.WriteLine(p3[i].ToString());
            }
            Console.ReadLine();

        }
    }
}
