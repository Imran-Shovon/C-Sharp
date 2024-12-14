using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Loops
{
    internal class DoWhileLoop
    {
        public void DoWhileLoopCheck(int number)
        {
            do
            {
                if (number == 3)
                {
                    Console.WriteLine("Breaking the loop!");
                    break;
                }

                Console.WriteLine("Number: " + number);
                number++;
            }
            while (number <= 5);
        }
    }
}
