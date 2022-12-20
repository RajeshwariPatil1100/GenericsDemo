using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int max = FindMaximum.FindIntMax(123, 456, 789);
            Console.WriteLine(max);
            float floatmax = FindMaximum.FindfloatMax(1.2f, 2.3f, 3.4f );
            Console.WriteLine(floatmax);
        }
    }
}