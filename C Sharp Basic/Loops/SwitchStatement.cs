using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Loops
{
    internal class SwitchStatement
    {
        //simple qwitch statement
        public void FruitCheck(string fruit)
        {
            switch (fruit)
            {
                case "Apple":
                    Console.WriteLine("It's an Apple!");
                    break;

                case "Banana":
                    Console.WriteLine("It's a Banana");
                    break;
                default:
                    Console.WriteLine("Unknown fruit!");
                    break;
            }
        }

        public void CheckNumberOrNot(object number)
        {
            switch (number)
            {
                case int Decimalnumber when Decimalnumber > 10:
                    Console.WriteLine($"Number {Decimalnumber} is greater than 10");
                    break;
                case int Decimalnumber:
                    Console.WriteLine($"Number is less than {number}");
                    break;

                default:
                    Console.WriteLine("Not a number.");
                    break;
            }
            
        }
    }
}
