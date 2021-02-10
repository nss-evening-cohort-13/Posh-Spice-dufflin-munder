using System;
using System.Collections.Generic;
using System.Text;

namespace DufflinMunder.Employees
{
    class SalesEmployee : EmployeeBase
    {
        public Dictionary<int, Sales> Sales { get; set; } = new Dictionary<int, Sales>();
    }
}
