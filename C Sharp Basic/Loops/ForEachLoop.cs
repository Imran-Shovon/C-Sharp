using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Loops
{
    internal class ForEachLoop
    {
        public void ForEachLoopCheck()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit: " + fruit);
            }
        }

        //Iterating over Dictionary.
        public void IteratingDictionary()
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 1, "Cricket" },
            { 2, "Football" },
            { 3, "Rugby" }
        };

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }
        
    }
}
