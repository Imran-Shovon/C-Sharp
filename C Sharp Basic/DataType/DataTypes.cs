using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.DataType
{
    internal class DataTypes
    {
        //Value Data Types
        public char character = 'S';
        public int number = 227;
        public short shortNumber = 56;
        public long longNumber = 4564;
        public uint unsignedInt = 95;
        public ushort unsignedShort = 76;
        public ulong unsignedLong = 362438832;
        public double doubleNumber = 98.3434343;
        public float floatNumber = 3.4354343f;
        public decimal decimalNumber = 398.43m;

        public void GetDataTypesOutputs()
        {
            Console.WriteLine("character" + character);
            Console.WriteLine("number" + number);
            Console.WriteLine("shortNumber" + shortNumber);
            Console.WriteLine("longNumber" + longNumber);
            Console.WriteLine("unsignedInt" + unsignedInt);
            Console.WriteLine("unsignedShort" + unsignedShort);
            Console.WriteLine("unsignedLong" + unsignedLong);
            Console.WriteLine("doubleNumber" + doubleNumber);
            Console.WriteLine("floatNumber" + floatNumber);
            Console.WriteLine("decimalNumber" + decimalNumber);
        }


        // the Reference data types
        //String 
        string message1 = "Hello"; //Creating through string keyword.
        String message2 = "Welcome"; //Creating through String class.

        //Object 
        /* Object is an instance of a class. It represents a real-world entity and is used to 
         * access the methods and properties defined in the class.
         */
        object obj = 20;

        //pointer


    }
}
