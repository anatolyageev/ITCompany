using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    public abstract class Employee
    {
        protected long Id { get; set; }
        protected string Name { get; set; }
        protected string Position { get; set; }
        protected double Salary { get; set; }
        protected string Department { get; set; }

        //void MeDelegMeating EventHandler(Meeting m)
        //{

        //}
        public abstract void DoWork(Employee e);
        public abstract void MakeReport(Employee e, string title, string body, DateTime ReportDate);
        public abstract void TakeVacation(Employee e, DateTime DateFrom, DateTime DateTo);
        public abstract void PerformTask(Employee e, DateTime DateFrom, DateTime DateTo, Employee executor);
    }
}
