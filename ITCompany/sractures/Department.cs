using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    class Department
    {
        public string Name { get; set; }
        public Employee[] employees;
        private readonly int sizeOfDepartment;
        public int NumberEmploees { get; set; }

        public Department(string name, int sizeOfDepartment)
        {
            this.Name = name;
            NumberEmploees = 0;
            this.sizeOfDepartment = sizeOfDepartment;
            employees = new Employee[sizeOfDepartment];
        }

        public Employee this [int pos]
        {
            get
            {
                if (pos >= employees.Length || pos < 0)
                    throw new IndexOutOfRangeException();
                else
                    return (Employee)employees[pos];
            }
            set
            {
                employees[pos] = (Employee)value;
            }
        }


        public override string ToString()
        {
            return $"Name:{Name}, " +
                   $"Employees:{employees}," +
                   $"sizeOfDepartment:{sizeOfDepartment}," +
                   $"numberEmploees:{NumberEmploees}";
        }

        public void AddEmployee(Employee employee)
        {
            if (NumberEmploees < employees.Length)
            {
                employees[NumberEmploees] = employee;
                NumberEmploees++;
            }
            else
            {
                Console.Write("Department cannot afford more epleyees.");
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            if (NumberEmploees > 0)
            {
                int i = 0;

                while (i< NumberEmploees)
                {
                    if(employees[i] == employee)
                    {
                        for(int j = i+1;j< NumberEmploees; j++,i++)
                        {
                            employees[i] = employees[j];
                        }
                        NumberEmploees--;
                        break;
                    }
                    i++;
                }
                
            }
        }
    }
}
