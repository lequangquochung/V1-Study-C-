using System;
using System.Collections.Generic;
using System.Text;

namespace exercise01
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");
            Console.WriteLine("1.Add new product");
            Console.WriteLine("2.Remove product");
            Console.WriteLine("3.Iterate product list");
            Console.WriteLine("4.Search product");
            Console.WriteLine("5.Exit");
            int pick = int.Parse(Console.ReadLine());
            var shop = new Shop();
            switch (pick)
            {
                case 1:
                    Shop.addProduct();
                    Main();
                    break;
                case 2:
                    Shop.removeProduct();
                    Main();
                    break;
                case 3:
                    Shop.IterateProductList();
                    Main();
                    break;
                case 4:
                    Shop.searchProduct();
                    Main();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Error ! Try Again.");
                    break;
            }
        }

    }
}
