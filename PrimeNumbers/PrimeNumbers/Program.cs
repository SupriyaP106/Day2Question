using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max,count;
            Console.WriteLine("Enter min num");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max num");
            max = int.Parse(Console.ReadLine());

            if(min<max)
            {
                for(int i=min; i<=max;i++)
                {
                    count = 1;

                    for (int j = 2; j <= i / 2; ++j)
                    {
                        if (i % j == 0)
                        {
                            count = 0;
                            break;
                        }
                    }

                    
                    if (count == 1)
                        Console.WriteLine(i);
                }
            }
            Console.WriteLine("Changes done by Susmitha Janarthanan");

        }
    }
}
