using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Variables
{
    internal class TypesOfVariables
    {
        // local variable age
        public int age = 0;

        //Static variable
        static int staticVariable;

        //Constant variable
        public const double PI = 3.1416;

        //ReadOnly Varibale 
        public readonly int readonlyVaribale = 30;

        //Implicitly Typed Local Variables
        //Not possible in a class.
        //public var implicitlyTypedVariable = 20;

        //dynamic Type variable
        dynamic dynamicVariable = "Hello";

        public static void addStr(dynamic input1, dynamic input2)
        {
            dynamic result = input1 + input2;
            Console.WriteLine(result);
        }


    }
}
