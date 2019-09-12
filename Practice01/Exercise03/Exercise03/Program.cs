using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int team;
            string str="";
            Console.WriteLine("Hello World!");
            Console.WriteLine("Nhap so doi bong");
            team = int.Parse(Console.ReadLine());
            for(int i = 1; i <= team; i++)
            {
                Console.WriteLine("Nhap ten doi bong");
                str = Console.ReadLine();
                Console.WriteLine(str);


            }
            
        }
    }
}
