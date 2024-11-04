using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justTEest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 5;

            for (int j = 1; j <= height; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int j = height; j >= 1; j--)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
