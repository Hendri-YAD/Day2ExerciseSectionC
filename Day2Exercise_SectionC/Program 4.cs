using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise_SectionC
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance travelled in km: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            double sum = 2.40;

            if (distance <= 0.5)
            {
                Console.WriteLine("Total fare is ${0}", sum);
            }
            else if (distance <= 9.0)
            {
                sum += 0.04 * (distance * 10 - 5);
                Console.WriteLine("Total fare is ${0}", sum);
            }
            else
            {
                sum = sum + 85 * 0.04 + (distance * 10 - 90) * 0.05;
                Console.WriteLine("Total fare is ${0:0.0}", sum);
            }           
        }
    }
}
