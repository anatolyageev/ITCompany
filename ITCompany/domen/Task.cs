using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    class Task
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Creation_date { get; set; }
        public string Due_date { get; set; }
        public string Creator { get; set; }
        public string Executor { get; set; }

        public Task(string title, string body, string creation_date, string due_date, string creator, string executor)
        {
            Title = title;
            Body = body;
            Creation_date = creation_date;
            Due_date = due_date;
            Creator = creator;
            Executor = executor;
        }

        public override bool Equals(object obj)
        {
            var task = obj as Task;
            return task != null &&
                   Title == task.Title &&
                   Body == task.Body &&
                   Creation_date == task.Creation_date &&
                   Due_date == task.Due_date &&
                   Creator == task.Creator &&
                   Executor == task.Executor;
        }

        public override int GetHashCode()
        {
            var hashCode = 1460635056;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Body);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Creation_date);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Due_date);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Creator);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Executor);
            return hashCode;
        }

        public override string ToString()
        {

            return $"Title:{Title}, " +
                $"Body:{Body}, " +
                $"Creation_date:{Creation_date}, " +
                $"Due_date: {Due_date}" +
                $"Creator: {Creator}" +
                $"Executor: {Executor}";
        }
    }
}
