using System;
using System.Collections.Generic;
using System.Text;

namespace exercise01
{
    public class product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int[] rate { get; set; }
        public void ViewInfor()
        {
            Console.WriteLine($"Product: {Name}\nDescription: {Description}\nPrice : {Price} ");
        }
    }
}


    
