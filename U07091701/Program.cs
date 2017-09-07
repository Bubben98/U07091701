using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U07091701
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            ArrayList ProductList = new ArrayList();

            ProductList.Add(new Product() { Name = "Biltemakörv", Price = 5 });
            ProductList.Add(new Product() { Name = "Maxikörv", Price = 6 });
            ProductList.Add(new Product() { Name = "Ikeakörv", Price = 7 });
            ProductList.Add(new Product() { Name = "Kioskkörv", Price = 12 });
            ProductList.Add(new Product() { Name = "Sibyllakörv", Price = 15 });

            int c = ProductList.Count;
            Console.WriteLine("De finns " + c + " producter.");

            
            foreach (Product x in ProductList)
            {
                Console.Write(x.Name + "|");
               
                    
            }

            foreach (Product i in ProductList)
            {
                if (i.Price>max)
                {
                    max = i.Price;
                    
                }
            }
            Console.WriteLine("\n Dyraste produkten är: " + max);

            double sum = 0;
            foreach (Product p in ProductList)
            {
                sum += p.Price;
            }
            double medel = sum / ProductList.Count;
            Console.WriteLine("medelvärdet är: " + medel);

            foreach (Product x in ProductList)
            {
                Console.WriteLine(x.Name + "("+x.Price+")");


            }

            Console.ReadKey();





        }
    }
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
  
}
