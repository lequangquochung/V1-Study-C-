using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input");
            int age = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++){
                if (age < 20)
                {
                    Console.WriteLine("Sai");
                    age = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(" Welcome");
                }
            }
            
           
        }
    }
}
