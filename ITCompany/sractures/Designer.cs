using System;

namespace ITCompany
{
    class Designer : Employee

    {

        public Designer(string Name, string Position, double Salary, string Department)
        {
            this.Name = Name;
            this.Position = Position;
            this.Salary = Salary;
            this.Department = Department;
        }

        public void CreateDesign()
        {
            Console.Write(this.Name + " doing designe.");
        }

        public void CreateMockup()
        {
            Console.Write(this.Name + " doing mockup.");
        }

        public override void DoWork(Employee e)
        {
            Console.Write(this.Name + " doing designe project.");
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
