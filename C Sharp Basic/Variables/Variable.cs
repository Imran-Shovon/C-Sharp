using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Variables
{
    internal class Variable
    {
         //int age=-10;
         public int age;
        public void DisplayAge()
        {
            if (age <= 0)
            {
                Console.WriteLine("Please set the age first");
                return;
            }
            Console.WriteLine($"Age is : {age}");
        }

        public void SetAge( int age )
        {
            if (age < 0)
            {
                Console.WriteLine("Age can not be less than");
                return;
            }
            this.age = age;
        }
    }
}
