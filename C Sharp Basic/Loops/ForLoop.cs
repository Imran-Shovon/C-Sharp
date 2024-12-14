using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Loops
{
    internal class ForLoop
    {
        public void ForLoopCheck(string[] fruits)
        {
            //string[] fruits = { "Apple", "Banana", "Cherry" };
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine("Fruit: " + fruits[i]);
            }
        }
    }
}
