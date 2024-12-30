using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Array
{
    internal class Arrays
    {
        public void Showtemperature()
        {
            int[] temperatures = { 30, 32, 31, 32, 32, 32 };
            Console.WriteLine($"Temperature of Day 4 is {temperatures[3]}");
        }

        //Foreach loop in Array
        public void ForEachLoopInArray()
        {
            string[] cars = { "BMW", "Volvo", "Ford", "Mazda" };
            foreach(var car in cars)
            {
                Console.WriteLine($"Car name is: {car}");
            }
            
        }
    }
}
