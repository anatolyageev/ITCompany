using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{

    public class DateDoneComparer : IComparer
    {
        public DateDoneComparer() { }
        int IComparer.Compare(object x, object y)
        {
            Report t1 = (Report)x;
            Report t2 = (Report)y;
            if (t1.Done_date < t2.Done_date)
            {
                return -1;
            }
            else if (t1.Done_date == t2.Done_date)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    public class ReportCreateDateComparer : IComparer
    {
        public ReportCreateDateComparer() { }
        int IComparer.Compare(object x, object y)
        {
            Report t1 = (Report)x;
            Report t2 = (Report)y;
            if (t1.Creation_date < t2.Creation_date)
            {
                return -1;
            }
            else if (t1.Creation_date == t2.Creation_date)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    internal class Report : ICloneable, IPrintable, IStorable
    {
        public Employee Owner { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Creation_date { get; set; }
        public DateTime Done_date { get; set; }
        public string Report_type { get; set; }



        public Report(Employee owner, string title, string body, DateTime creation_date,DateTime Done_date, string report_type)
        {
            Owner = owner;
            Title = title;
            Body = body;
            Creation_date = creation_date;
            Report_type = report_type;
        }

        public object Clone()
        {
            return new Report(this.Owner,this.Title,this.Body,this.Creation_date,this.Done_date,this.Report_type);
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public void Save()
        {
            Console.WriteLine("File saved");
        }

        public void Restore()
        {
            Console.WriteLine("File restored");
        }

        public override bool Equals(object obj)
        {
            var report = obj as Report;
            return report != null &&
                   EqualityComparer<Employee>.Default.Equals(Owner, report.Owner) &&
                   Title == report.Title &&
                   Body == report.Body &&
                   Creation_date == report.Creation_date &&
                   Report_type == report.Report_type;
        }

        public override int GetHashCode()
        {
            var hashCode = 736236243;
            hashCode = hashCode * -1521134295 + EqualityComparer<Employee>.Default.GetHashCode(Owner);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Body);
            hashCode = hashCode * -1521134295 + Creation_date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Report_type);
            return hashCode;
        }

        public static bool operator ==(Report report1, Report report2)
        {
            return EqualityComparer<Report>.Default.Equals(report1, report2);
        }

        public static bool operator !=(Report report1, Report report2)
        {
            return !(report1 == report2);
        }
    }
}
