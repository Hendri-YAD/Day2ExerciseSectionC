using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise_SectionC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name :");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your gender in M or F: ");
            char gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M')
            {
                Console.WriteLine("Good Morning Mr. {0}", name);
            } else
            {
                Console.WriteLine("Good Morning Mrs. {0}", name);
            }            
        }
    }
}
