using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    public abstract class School
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public abstract string GenerateId();

    }
}
