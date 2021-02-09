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

            var SalesEmployees = new List<SalesEmployee>
            {
                Jim,
                Dwight
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
                        Console.WriteLine("Which Salesperson are you?");
                        foreach (var emp in SalesEmployees)
                        {
                            Console.WriteLine(emp.EmployeeName);
                        }
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
