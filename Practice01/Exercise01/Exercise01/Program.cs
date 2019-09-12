using System;
using System.Text;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            
            Console.WriteLine("Input your name ");
            name = Console.ReadLine();
            Console.WriteLine("Input your age ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Name = " + name +", " + "Age = "+ age);

        }
    }
}
