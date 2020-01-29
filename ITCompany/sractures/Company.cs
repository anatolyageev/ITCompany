using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    class Company: IEnumerable
    {
        #region Fealds and propertees
        public string Name { get; set; }
        public Manager Ceo { get; set; }
        public List<Department> Departments { get; set; }
        #endregion


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

        #region Indexators
        public Department this[int index]
        {
            get => index >= 0 && index < Departments.Count ? Departments[index] : throw new IndexOutOfRangeException();
        }
        public Department this[string name]
        {
            get => Departments.Any(e => e.Name == name) ? Departments.Find(e => e.Name == name) : throw new Exception("Object with given criteria is not found");
        }
        #endregion


        public override string ToString()
        {
            return $"Name:{Name}, " +
                   $"Ceo:{Ceo}," +
                   $"Departments:{Departments}";
        }

        public IEnumerator GetEnumerator()
        {
            return Departments.GetEnumerator();
        }
    }
}
