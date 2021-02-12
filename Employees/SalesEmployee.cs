using System;
using System.Collections.Generic;
using System.Text;

namespace DufflinMunder.Employees
{
    class SalesEmployee : EmployeeBase
    {
        public Dictionary<int, Sale> SalesDictionary { get; set; } = new Dictionary<int, Sale>();
    }
}