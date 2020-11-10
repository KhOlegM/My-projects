using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFromTest
{
    class Program
    {
        static bool? aBool
        {
            set;
            get;
        }

        static void Main(string[] args)
        {
            if (aBool.HasValue)
            {
                Console.WriteLine("is not null 1");
            }
            else
            {
                Console.WriteLine("is null");
                Console.WriteLine("Convert.ToBoolean({0})",Convert.ToBoolean(aBool));
            }

            aBool = true;
            if (aBool ?? false)
            {
                Console.WriteLine("is true");
            }

            aBool = false;
            if (aBool.HasValue && !aBool.Value)
            {
                Console.WriteLine("is false");
            }
        }
    }
}
