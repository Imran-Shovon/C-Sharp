using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Loops
{
    internal class IfStatement
    {
        public void AgeIs18orNot(int age)
        {
            if (age > 18 && age < 30)
            {
                Console.WriteLine("Young person");
            }
            else if (age > 30)
            {
                Console.WriteLine("Oldish");
            }
            else
            {
                if(age < 10)
                {
                    Console.WriteLine("Child");
                }
                else
                {
                    Console.WriteLine("Under 18");
                }
            }
        }
    }
}
