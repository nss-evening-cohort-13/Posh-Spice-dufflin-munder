using System;
using System.Collections.Generic;
using System.Text;

namespace DufflinMunder.Employees
{
    class SalesEmployee : EmployeeBase
    {
        public Dictionary<Sales.ClientId, Sales> Sales { get; set; } = new Dictionary<Sales.ClientId, Sales>();
    }
}
