using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Loop_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for(int i=0,j=10; i<j; i++, j--)
            {
                Console.WriteLine($"i and j {i} , {j}");
            }

            Console.ReadKey();
        }
    }
}
