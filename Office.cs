using System;
using System.Collections.Generic;
using System.Text;
using DufflinMunder.Employees;

namespace DufflinMunder
{
    class Office
    {
        public string Name { get; set; }
        public List<SalesEmployee> OfficeEmployees { get; set; } = new List<SalesEmployee>();

        public Office(string name)
        {
            Name = name;
        }
    }
}
