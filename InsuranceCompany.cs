using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab3
{
    internal class InsuranceCompany : Organization
    {
        public string? TypeOfInsurance { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Insurance Company: {Name}, Address: {Address}, Type of Insurance: {TypeOfInsurance}");
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            InsuranceCompany ins = (InsuranceCompany)obj;
            return Name.Equals(ins.Name) && Address.Equals(ins.Address) && TypeOfInsurance.Equals(ins.TypeOfInsurance);
        }
    }
}
