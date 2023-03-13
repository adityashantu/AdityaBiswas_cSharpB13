using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class ParameterModifier
    {
        public void Print(params string[] messages)
        {
            foreach (string s in messages)
            {
                Console.WriteLine(s);
            }
        }
    }
}
