using System;
using System.Collections.Generic;
using DufflinMunder.Employees;

namespace DufflinMunder
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jim = new SalesEmployee();
            Jim.EmployeeName = "Jim";
            var Dwight = new SalesEmployee();
            Dwight.EmployeeName = "Dwight";
            var Phyllis = new SalesEmployee { EmployeeName = "Phyllis Leaf" };

            var SalesEmployees = new List<SalesEmployee>
            {
                Jim,
                Dwight,
                Phyllis,
            };
            var initialSelection = "";
            do
            {
                Console.WriteLine($@"
                        Welcome to Dufflin/Munder Cardboard Co. 
                        Sales Portal!

                        1.Enter Sales
                        2.Generate Report For Accountant
                        3.Add New Sales Employee
                        4.Find a Sale
                        5.Exit 
                        ------------------");

                initialSelection = Console.ReadLine();
                switch (initialSelection)
                {
                    case "1":
                        Console.WriteLine("Which person are you?");
                        var counter = 1;
                        foreach (var employee in SalesEmployees)
                        {
                            Console.WriteLine($"{counter}. {employee.EmployeeName}");
                            counter++;
                        }
                        var employeeChoice = Console.ReadLine();
                        Console.WriteLine($"Hi, {SalesEmployees[(Int32.Parse(employeeChoice) - 1)].EmployeeName} ");
                        break;
                    case "2":
                        Console.WriteLine("case 2");
                        break;
                    case "3":
                        Console.WriteLine("case 3");
                        break;
                    case "4":
                        Console.WriteLine("case 4");
                        break;
                    default:
                        Console.WriteLine("invalid selection");
                        break;
                }

            } while (initialSelection != "5");

        }
    }
}
