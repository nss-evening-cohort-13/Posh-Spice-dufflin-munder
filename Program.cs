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
            Jim.EmployeeName = "Jim Halpert";
            var Dwight = new SalesEmployee();
            Dwight.EmployeeName = "Dwight Schrute";
            var Phyllis = new SalesEmployee { EmployeeName = "Phyllis Leaf" };

            var SalesEmployees = new List<SalesEmployee>
            {
                Jim,
                Dwight,
                Phyllis,
            };

            var dummySale1 = new Sales(Phyllis.EmployeeName, "Taco Hell", 2433, 52000, Recurring.Annually, "5 months");
            var dummySale2 = new Sales(Dwight.EmployeeName, "Bed, Math and Beyond", 0444, 29340, Recurring.Monthly, "10 months");
            var dummySale3 = new Sales(Jim.EmployeeName, "Catalina Wine Mixer", 4444, 125000, Recurring.Annually, "1 month");
            var dummySale4 = new Sales(Phyllis.EmployeeName, "Vance Refridgeration", 5252, 44500, Recurring.Weekly, "1 month");
            Phyllis.Sales.Add(dummySale1.ClientId, dummySale1);
            Phyllis.Sales.Add(dummySale4.ClientId, dummySale4);
            Dwight.Sales.Add(dummySale2.ClientId, dummySale2);
            Jim.Sales.Add(dummySale3.ClientId, dummySale3);

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
                        Console.Clear();

                        Console.WriteLine("Which person are you?");

                        var counter = 1;

                        foreach (var employee in SalesEmployees)
                        {
                            Console.WriteLine($"{counter}. {employee.EmployeeName}");
                            counter++;
                        }

                        var employeeInput = Console.ReadLine();
                        var chosenEmployee = SalesEmployees[(Int32.Parse(employeeInput) - 1)];

                        Console.Clear();

                        Console.WriteLine($"Hi, {chosenEmployee.EmployeeName}!! ");
                        Console.WriteLine();
                        Console.WriteLine($"Sales Agent: {chosenEmployee.EmployeeName} ");

                        Console.Write("Client: ");
                        string clientName = Console.ReadLine();

                        Console.Write("ClientId: ");
                        var clientId = Console.ReadLine();  

                        Console.Write("Sale: $");
                        var salesTotal = Console.ReadLine();
                        
                        StartOfRecurring:
                        Console.Write("Recurring (ex: Monthly, Annually, Quarterly): ");
                        var recurringAmount = Console.ReadLine();
                        Recurring passedInput = Recurring.None;
                        if(Enum.IsDefined(typeof(Recurring), recurringAmount))
                        {
                            passedInput = (Recurring)Enum.Parse(typeof(Recurring), recurringAmount);
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Input! Try Monthly, Annually, Quarterly, or Weekly.");
                            goto StartOfRecurring;
                        }

                        Console.Write("Time Frame: ");
                        var timeFrame = Console.ReadLine();

                        chosenEmployee.Sales.Add(Int32.Parse(clientId), new Sales(chosenEmployee.EmployeeName, clientName, Int32.Parse(clientId), Int32.Parse(salesTotal), passedInput, timeFrame));

                        Console.Clear();
                        Console.WriteLine($"Sale Input Recieved! Good work {chosenEmployee.EmployeeName}");


                        break;
                    case "2":
                        Console.WriteLine("case 2");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Please enter new saleperson's name:");
                        var newSalesperson = Console.ReadLine();
                        var newPerson = new SalesEmployee { EmployeeName = newSalesperson};
                        SalesEmployees.Add(newPerson);
                        Console.Clear();
                        foreach (var emp in SalesEmployees)
                        {
                            Console.WriteLine(emp.EmployeeName);
                        }
                        
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Please enter the client ID number:");
                        var clientNumber = Console.ReadLine();
                        var dictionaryOfAllSales = new Dictionary<int, Sales>();
                        foreach (var employee in SalesEmployees)
                        {
                            
                            foreach (var sale in employee.Sales)
                            {
                                dictionaryOfAllSales.Add(sale.Key, sale.Value);  
                            }
                        }
                        Console.WriteLine(dictionaryOfAllSales[Int32.Parse(clientNumber)].SalesPerson);
                        Console.WriteLine(dictionaryOfAllSales[Int32.Parse(clientNumber)].Client);
                        break;
                    default:
                        Console.WriteLine("bu-bye");
                        break;
                }

            } while (initialSelection != "5");

        }
    }
}
