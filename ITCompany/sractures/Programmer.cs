using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    class Programmer : Employee
    {
        public Programmer(string Name, string Position, double Salary, string Department)
        {
            this.Name = Name;
            this.Position = Position;
            this.Salary = Salary;
            this.Department = Department;
        }

        public void WriteCode()
        {
            Console.Write(this.Name + " writing a code.");
        }

        public void DebugCode()
        {
            Console.Write(this.Name + " debuggin a code.");
        }
        public void RefactorCode()
        {
            Console.Write(this.Name + " refacroring code.");
        }

        public override void DoWork(Employee e)
        {
            Console.WriteLine(this.Name + " doing project.");
        }

        public override void MakeReport(Employee e, string title, string body, DateTime ReportDate)
        {
            Console.Write(this.Name + " done report");
        }

        public override void PerformTask(Employee e, DateTime DateFrom, DateTime DateTo, Employee executor)
        {
            Console.Write(this.Name + " performe task");
        }

        public override void TakeVacation(Employee e, DateTime DateFrom, DateTime DateTo)
        {
            Console.Write(this.Name + " took vocation");
        }

        public override string ToString()
        {
            return $"Name:{Name}, Position:{Position}, Salary:{Salary}, Department:{Department}";
        }

    }
}
