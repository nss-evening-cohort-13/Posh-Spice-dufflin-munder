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
            var Oscar = new AccountingEmployee();
            Oscar.EmployeeName = "Oscar";
            var Kevin = new AccountingEmployee();
            Kevin.EmployeeName = "Kevin";

            var SalesEmployees = new List<SalesEmployee>
            {
                Jim,
                Dwight
            };
            var Accountants = new List<AccountingEmployee>
            {
                Oscar,
                Kevin
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
                        foreach (var emp in SalesEmployees)
                        {
                            Console.WriteLine(emp.EmployeeName);
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Which accountant are you?");
                        var counter = 1;
                        foreach (var employee in Accountants)
                        {
                            Console.WriteLine($"{counter}. {employee.EmployeeName}");
                            counter++;
                        }
                        var accountantSelected = counter;
                        Console.WriteLine($"Monthly Sales Report For: {accountantSelected}");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Please enter new saleperson's name:");
                        var newSalesperson = Console.ReadLine();
                        var newPerson = new SalesEmployee { EmployeeName = newSalesperson};
                        SalesEmployees.Add(newPerson);
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("case 4");
                        break;
                    default:
                        Console.WriteLine("bu-bye");
                        break;
                }

            } while (initialSelection != "5");

        }
    }
}