using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise_SectionC
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 80 && marks <= 100)
            {
                Console.WriteLine("You scored {0} marks which is A grade.", marks);
            }
            else if (marks >= 60 && marks <= 79)
            {
                Console.WriteLine("You scored {0} marks which is B grade.", marks);
            }
            else if (marks >= 40 && marks <= 59)
            {
                Console.WriteLine("You scored {0} marks which is C grade.", marks);
            }
            else if (marks >= 0 && marks <= 39)
            {
                Console.WriteLine("You scored {0} marks which is F grade.", marks);
            }
            else if (marks < 0)
            {
                Console.WriteLine("**Error**");
            }
            else
            {
                Console.WriteLine("**Error**");
            }
        }
    }
}
