using lab3;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Organization[] organizations = new Organization[2];

        organizations[0] = new InsuranceCompany()
        {
            Name = "ABC Insurance",
            Address = "123 Main St",
            TypeOfInsurance = "Life Insurance"
        };

        organizations[1] = new Factory()
        {
            Name = "XYZ Factory",
            Address = "456 Industrial Blvd",
            NumberOfEmployees = 100
        };

        var index = 0;
        foreach (var org in organizations)
        {
            org.PrintInfo();

            // получаем первый элемент массива
            if (index - 1 == -1)
            {
                index = 1;
            }

            if (org.Equals(organizations[index - 1]))
            {
                Console.WriteLine("This organization is the same as the first one.");
            }
            else
            {
                Console.WriteLine("This organization is not the same as the first one.");
            }
        }
    }
}