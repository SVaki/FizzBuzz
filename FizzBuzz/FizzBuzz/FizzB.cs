using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzB
    {
        public void FizzBuzz()
        {
            int i;

            for (i = 1; i <= 100; i++)
            {
                string strOutput = "";
                if (i % 3 == 0)
                {
                    strOutput = strOutput + "Fizz";
                }

                if (i % 5 == 0)
                {
                    strOutput += "Buzz";
                }
                if (strOutput == "")
                {
                    Console.WriteLine(i);
                }
                else
                    Console.WriteLine(strOutput);
            }
            Console.ReadLine();
        }
    }
}
