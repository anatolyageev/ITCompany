using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Manager ceo = new Manager("Ivan", "CEO", 100000.0);
            Company company = new Company("SimplIt", ceo);
            Department itDepartment = new Department("IT Department", 11);
            Manager manager1 = new Manager("Roman", "Project Manager", 10000);
            Employee programmer1 = new Programmer("Anatoly", "Junior c# dev", 1000, "IT Department");
            Employee programmer2 = new Programmer("Vasiliy", "Junior c# dev", 1200, "IT Department");
            itDepartment.AddEmployee(manager1);
            itDepartment.AddEmployee(programmer1);
            itDepartment.AddEmployee(programmer2);
            manager1.DoWork(manager1);
            
            programmer1.DoWork(programmer1);
            programmer2.DoWork(programmer1);
            Console.WriteLine(itDepartment);
            PrintDepartmen(itDepartment);
            Console.WriteLine("Deleting employee...");
            manager1.Fire(itDepartment, programmer2);
            PrintDepartmen(itDepartment);
            Console.Write(company);
            Console.ReadKey();

        }

        private static void PrintDepartmen(Department itDepartment)
        {
            for (int i = 0; i < itDepartment.NumberEmploees; i++)
            {
                Console.WriteLine(itDepartment.employees[i]);
            }
        }
    }
}
