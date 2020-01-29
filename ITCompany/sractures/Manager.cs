using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    internal class Manager : Employee
    {
        public Manager(string Name, string Position, double salary)
        {
            this.Name = Name;
            this.Position = Position;
            this.Salary = salary;
        }

        public event DelegMeating OnArangeMeeting;

        public Manager(string Name, string Position, double Salary, string Department)
        {
            this.Name = Name;
            this.Position = Position;
            this.Salary = Salary;
            this.Department = Department;
        }

        public Employee Hire(string Name, string Position, double salary)
        {
            Employee employee = new Programmer(Name, Position, Salary, this.Department);
            return employee;
        }

        public void Fire(Department d, Employee e)
        {
            d.RemoveEmployee(e);
        }


        public void ArrangeMeeting()
        {

            if(OnArangeMeeting != null)
            {
                OnArangeMeeting(new Meeting());
            }
            Console.Write(this.Name + " arrenge meeting.");
        }

        public override void DoWork(Employee e)
        {
            Console.Write(this.Name + " doing project.");
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
