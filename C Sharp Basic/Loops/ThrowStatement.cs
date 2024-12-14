using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.Loops
{
    internal class ThrowStatement
    {
        
            public void displaySubject(string subject1)
            {
                if (subject1 ==null)
                {
                    throw new NullReferenceException("Exception Message");
                }
        }
    }
}
