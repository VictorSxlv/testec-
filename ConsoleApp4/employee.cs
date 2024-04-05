using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public employee(int id, string name, double salary) {
        
            Id = id;
            Name = name;    
            Salary = salary;
        
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += (percentage / 100) * Salary;

        }

        public override string ToString()
        {
            return Id +
                ", " +
                Name +
                ", " +
                Salary.ToString("F2");

        }

    }
}
