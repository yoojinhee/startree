using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력 :");
            int line = int.Parse(Console.ReadLine());

            for(int i=0; i<line; i++)//4
            {
                for(int j=0; j< line-i-1; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<= (i+1)*2-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
