using System;
using System.Collections.Generic;
using System.Text;

namespace DufflinMunder.Employees
{
    class SalesEmployee : EmployeeBase
    {
        public List<Sales> Sales { get; set; } = new List<Sales>();
    }
}
