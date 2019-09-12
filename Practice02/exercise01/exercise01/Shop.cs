using System;
using System.Collections.Generic;
using System.Text;

namespace exercise01
{
    public class Shop
    {
        private static List<product> ProductList = new List<product>();
        public static void addProduct()
        {
            product Product = new product();
            Console.WriteLine("Product Name");
            Product.Name = Console.ReadLine();
            Console.WriteLine("Product Description");
            Product.Description = Console.ReadLine();

            price: Console.WriteLine("Product Price");

            Product.Price = float.Parse(Console.ReadLine());
            if (Product.Price < 0 || Product.Price > 100)
            {
                Console.WriteLine("Error Price ! Enter again.");
                goto price;
            }
            ProductList.Add(Product);
        }
        public static void removeProduct()
        {            
            string produckRM = Console.ReadLine();
            Console.WriteLine("2.Remove product\n");            
            foreach (var nameItem in ProductList)
            {
                ProductList.Remove(nameItem);
                Console.WriteLine("Complete");
                Console.WriteLine("_____________");
                break;
            }
            Console.WriteLine("_____________");
        }
        public static void IterateProductList()
        {
            Console.WriteLine("__________________");
            Console.WriteLine("3.Iterate product list\n");
            foreach (var produck in ProductList)
            {
                produck.ViewInfor();
            }
            Console.WriteLine("__________________");
        }
        public static void searchProduct()
        {
            int check = 0;
            string nameProduct = Console.ReadLine();
            foreach(var produck in ProductList)
            {
                if (produck.Name == nameProduct)
                {
                    produck.ViewInfor();
                    check++;
                }
            }
            if(check == 0)
            {
                Console.WriteLine("No Product");
            }
        }

    }
}
