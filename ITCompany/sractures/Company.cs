using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    class Company
    {
        public string Name { get; set; }
        public Manager Ceo { get; set; }
        public HashSet<Department> Departments { get; set; }

        public Company(string name, Manager ceo)
        {
            Name = name;
            this.Ceo = ceo;
        }

        public void addDepartment(Department d)
        {
            Departments.Add(d);
        }

        public void delDepartment(Department d)
        {
            Departments.Remove(d);
        }

        public override string ToString()
        {
            return $"Name:{Name}, " +
                   $"Ceo:{Ceo}," +
                   $"Departments:{Departments}";
        }
    }
}
