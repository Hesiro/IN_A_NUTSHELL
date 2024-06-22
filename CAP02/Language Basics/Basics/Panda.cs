using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Panda
    {
        public string Name;
        public static int Population;

        public Panda(string n)
        {
            Name = n;
            Population = Population + 1;
        }
    }
}
