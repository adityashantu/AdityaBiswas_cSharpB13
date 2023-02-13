using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class SubClass : Machine
    {
        public override void Start()
        {
            Console.WriteLine("Machine Started");
        }
    }
}