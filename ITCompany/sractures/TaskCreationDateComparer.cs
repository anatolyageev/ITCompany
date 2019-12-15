using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    class TaskCreationDateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Task t1 = (Task)x;
            Task t2 = (Task)y;
            return DateTime.Compare(t1.Creation_date, t2.Creation_date);
        }
    }
}
