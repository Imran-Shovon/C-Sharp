using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Loops
{
    internal class WhileLoop
    {
        public void WhileLoopCheck()
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if(number > 10)
                {
                    Console.WriteLine("Thank You! Your number is "+ number);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number greater than 10.");
                }
            }
        }
    }
}
