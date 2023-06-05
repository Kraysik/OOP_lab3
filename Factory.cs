using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab3
{
    internal class Factory : Organization
    {
        public int NumberOfEmployees { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Factory: {Name}, Address: {Address}, Number of Employees: {NumberOfEmployees}");
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Factory fac = (Factory)obj;
            return Name.Equals(fac.Name) && Address.Equals(fac.Address) && NumberOfEmployees == fac.NumberOfEmployees;
        }
    }
}
