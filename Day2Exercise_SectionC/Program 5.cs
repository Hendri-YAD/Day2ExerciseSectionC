using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise_SectionC
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a three digit number: ");
            int threeDig = Convert.ToInt32(Console.ReadLine());

            int firstDig = threeDig / 100;
            int secondDig = (threeDig % 100) / 10;
            int thirdDig = (threeDig % 10);

            int sum = (int) (Math.Pow(firstDig, 3) + Math.Pow(secondDig, 3) + Math.Pow(thirdDig, 3));

            if (sum == threeDig)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
