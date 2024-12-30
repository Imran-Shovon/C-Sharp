using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Array
{
    internal class MultiDimensionalArray
    {
        public void MultiDimensionalArrayobj(int[,] TwoDArray)
        {
            for (int i = 0; i < TwoDArray.GetLength(0); i++)
            {
                for (int j=0; j <TwoDArray.GetLength(1); j++)
                {
                    Console.WriteLine($"Row,Column[{i},{j}] {TwoDArray[i, j]}");
                }
            }
        }
    }
}
