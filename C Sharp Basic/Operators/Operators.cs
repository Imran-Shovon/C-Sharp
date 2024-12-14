using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Operators
{
    internal class Operators
    {
        int number = 10;
        public void Add(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
        }

        public void Subtract(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine(result);
        }

        public void Multiply(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine(result);
        }

        public void Divide(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine(result);
        }

    }
}
