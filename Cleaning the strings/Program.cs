using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_the_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "This looks5 grea8t!" ;

            string str = "";

            for (int i = 0; i < x.Length; i++)
            {
                if (!char.IsDigit(x[i]))
                {
                    str += x[i];
                }
            }
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
