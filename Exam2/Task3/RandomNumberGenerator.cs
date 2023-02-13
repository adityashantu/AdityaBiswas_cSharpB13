using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class RandomNumberGenerator
    {
        private static int _seed;
        private static Random _rand;

/*        public static RandomNumberGenerator()
        {
            _seed = DateTime.Now.Microsecond;
            _rand = new Random(_seed);
        }*/   //static class can not have instances. I guess that's why this constructor is showing an error. 

        public static int Generate()
        {
            return _rand.Next();
        }
    }
}
