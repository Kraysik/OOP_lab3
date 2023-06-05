using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Organization
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public abstract void PrintInfo();
        public abstract bool Equals(object obj);
    }
}
