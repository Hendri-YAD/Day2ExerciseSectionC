using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise_SectionC
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your gender in M or F: ");
            char gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 40 && gender == 'M')
            {
                Console.WriteLine("Good morning Uncle " + name);
            }
            else if (age >= 40 && gender == 'F')
            {
                Console.WriteLine("Good morning Aunty " + name);
            }
            else if (gender == 'M')
            {
                Console.WriteLine("Good morning Mr. " + name);
            }
            else
            {
                Console.WriteLine("Good morning Ms. " + name);
            }            
        }
    }
}
