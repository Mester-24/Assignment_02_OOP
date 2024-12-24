using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_oop
{
    internal class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        private string gender;
        public string Gender
        {
            get => gender;
            set
            {
                if (value != "M" && value != "F")
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
                gender = value;
            }
        }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }

        public Employee(int id, string name, string gender, SecurityLevel securityLevel, decimal salary, HiringDate hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {SecurityLevel}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, Hire Date: {HireDate}";
        }
    }   
}
