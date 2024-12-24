using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Association_Aggeration
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee[]? Employees { get; set; }
        public Department(string _Name)
        {
            Name = _Name;
        }
        public Department(string _name,Employee[] _employees) 
        { 
            Name= _name;
            Employees= _employees;
        }
    }
}
