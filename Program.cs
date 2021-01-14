using System;
using System.Collections.Generic;
using Polimorfism_Inheritance_Exercise.Entities;

namespace Polimorfism_Inheritance_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");

                Console.Write("Outsourced (y / n) ? ");
                string outsourc = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Employee em;
                if (outsourc == "n")
                {
                    em = new Employee(name, hours, valuePerHour);
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double ac = double.Parse(Console.ReadLine());
                    em = new OutsourcedEmployee(name, hours, valuePerHour, ac);
                }
                list.Add(em);
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach(var em in list)
            {
                Console.WriteLine(em);
            }
        }
    }
}
